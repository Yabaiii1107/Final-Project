namespace HR_Project
{
    partial class Dashboard
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
            if (disposing && (components != null)) components.Dispose();
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
            this.btnDashboardClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblApplicantLastName = new System.Windows.Forms.Label();
            this.lblApplicantFirstName = new System.Windows.Forms.Label();
            this.picBoxDashboardpfp = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnJobVacancies = new System.Windows.Forms.Button();
            this.btnMyApplication = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnStatusTracking = new System.Windows.Forms.Button();
            this.panelCardStatus = new System.Windows.Forms.Panel();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelAppliedPosition0 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAppliedPosition = new System.Windows.Forms.Label();
            this.panelMissingDocuments = new System.Windows.Forms.Panel();
            this.lblMissDocu = new System.Windows.Forms.Label();
            this.lblMissingDocuments = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblApplicantName1 = new System.Windows.Forms.Label();
            this.lblSectionDocuments = new System.Windows.Forms.Label();
            this.lblSectionProgress = new System.Windows.Forms.Label();
            this.dgvDocumentStatus = new System.Windows.Forms.DataGridView();
            this.colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApplicationProgress = new System.Windows.Forms.DataGridView();
            this.colStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStepStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInterviewSchedule = new System.Windows.Forms.Label();
            this.lblInterview = new System.Windows.Forms.Label();
            this.cmbApplicationSelector = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashboardpfp)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.panelCardStatus.SuspendLayout();
            this.panelAppliedPosition0.SuspendLayout();
            this.panelMissingDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationProgress)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.btnDashboardClose);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.lblApplicantLastName);
            this.panelHeader.Controls.Add(this.lblApplicantFirstName);
            this.panelHeader.Controls.Add(this.picBoxDashboardpfp);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(869, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // btnDashboardClose
            // 
            this.btnDashboardClose.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardClose.FlatAppearance.BorderSize = 0;
            this.btnDashboardClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardClose.ForeColor = System.Drawing.Color.Red;
            this.btnDashboardClose.Location = new System.Drawing.Point(833, 0);
            this.btnDashboardClose.Name = "btnDashboardClose";
            this.btnDashboardClose.Size = new System.Drawing.Size(36, 29);
            this.btnDashboardClose.TabIndex = 0;
            this.btnDashboardClose.Text = "X";
            this.btnDashboardClose.UseVisualStyleBackColor = false;
            this.btnDashboardClose.Click += new System.EventHandler(this.btnDashboardClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(752, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblApplicantLastName
            // 
            this.lblApplicantLastName.AutoSize = true;
            this.lblApplicantLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantLastName.ForeColor = System.Drawing.Color.White;
            this.lblApplicantLastName.Location = new System.Drawing.Point(610, 36);
            this.lblApplicantLastName.Name = "lblApplicantLastName";
            this.lblApplicantLastName.Size = new System.Drawing.Size(29, 15);
            this.lblApplicantLastName.TabIndex = 5;
            this.lblApplicantLastName.Text = "Last";
            // 
            // lblApplicantFirstName
            // 
            this.lblApplicantFirstName.AutoSize = true;
            this.lblApplicantFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantFirstName.ForeColor = System.Drawing.Color.White;
            this.lblApplicantFirstName.Location = new System.Drawing.Point(610, 18);
            this.lblApplicantFirstName.Name = "lblApplicantFirstName";
            this.lblApplicantFirstName.Size = new System.Drawing.Size(31, 15);
            this.lblApplicantFirstName.TabIndex = 4;
            this.lblApplicantFirstName.Text = "First";
            // 
            // picBoxDashboardpfp
            // 
            this.picBoxDashboardpfp.Location = new System.Drawing.Point(8, 8);
            this.picBoxDashboardpfp.Name = "picBoxDashboardpfp";
            this.picBoxDashboardpfp.Size = new System.Drawing.Size(44, 44);
            this.picBoxDashboardpfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDashboardpfp.TabIndex = 3;
            this.picBoxDashboardpfp.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Applicant Portal";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelNavigation.Controls.Add(this.btnDashboard);
            this.panelNavigation.Controls.Add(this.btnMyProfile);
            this.panelNavigation.Controls.Add(this.btnJobVacancies);
            this.panelNavigation.Controls.Add(this.btnMyApplication);
            this.panelNavigation.Controls.Add(this.btnDocuments);
            this.panelNavigation.Controls.Add(this.btnStatusTracking);
            this.panelNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(869, 42);
            this.panelNavigation.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(110, 42);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Location = new System.Drawing.Point(110, 0);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(110, 42);
            this.btnMyProfile.TabIndex = 1;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnJobVacancies
            // 
            this.btnJobVacancies.FlatAppearance.BorderSize = 0;
            this.btnJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobVacancies.Location = new System.Drawing.Point(220, 0);
            this.btnJobVacancies.Name = "btnJobVacancies";
            this.btnJobVacancies.Size = new System.Drawing.Size(120, 42);
            this.btnJobVacancies.TabIndex = 2;
            this.btnJobVacancies.Text = "Job Vacancies";
            this.btnJobVacancies.UseVisualStyleBackColor = false;
            this.btnJobVacancies.Click += new System.EventHandler(this.btnJobVacancies_Click);
            // 
            // btnMyApplication
            // 
            this.btnMyApplication.FlatAppearance.BorderSize = 0;
            this.btnMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApplication.Location = new System.Drawing.Point(340, 0);
            this.btnMyApplication.Name = "btnMyApplication";
            this.btnMyApplication.Size = new System.Drawing.Size(120, 42);
            this.btnMyApplication.TabIndex = 3;
            this.btnMyApplication.Text = "My Application";
            this.btnMyApplication.UseVisualStyleBackColor = false;
            this.btnMyApplication.Click += new System.EventHandler(this.btnMyApplication_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.FlatAppearance.BorderSize = 0;
            this.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocuments.Location = new System.Drawing.Point(460, 0);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(110, 42);
            this.btnDocuments.TabIndex = 4;
            this.btnDocuments.Text = "Documents";
            this.btnDocuments.UseVisualStyleBackColor = false;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnStatusTracking
            // 
            this.btnStatusTracking.FlatAppearance.BorderSize = 0;
            this.btnStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusTracking.Location = new System.Drawing.Point(570, 0);
            this.btnStatusTracking.Name = "btnStatusTracking";
            this.btnStatusTracking.Size = new System.Drawing.Size(130, 42);
            this.btnStatusTracking.TabIndex = 5;
            this.btnStatusTracking.Text = "Status Tracking";
            this.btnStatusTracking.UseVisualStyleBackColor = false;
            this.btnStatusTracking.Click += new System.EventHandler(this.btnStatusTracking_Click);
            // 
            // panelCardStatus
            // 
            this.panelCardStatus.BackColor = System.Drawing.Color.White;
            this.panelCardStatus.Controls.Add(this.lblCurrentStatus);
            this.panelCardStatus.Controls.Add(this.lblStatus);
            this.panelCardStatus.Location = new System.Drawing.Point(16, 155);
            this.panelCardStatus.Name = "panelCardStatus";
            this.panelCardStatus.Size = new System.Drawing.Size(190, 80);
            this.panelCardStatus.TabIndex = 12;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lblCurrentStatus.Location = new System.Drawing.Point(10, 14);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(35, 30);
            this.lblCurrentStatus.TabIndex = 0;
            this.lblCurrentStatus.Text = "—";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Current Status";
            // 
            // panelAppliedPosition0
            // 
            this.panelAppliedPosition0.BackColor = System.Drawing.Color.White;
            this.panelAppliedPosition0.Controls.Add(this.lblPosition);
            this.panelAppliedPosition0.Controls.Add(this.lblAppliedPosition);
            this.panelAppliedPosition0.Location = new System.Drawing.Point(226, 155);
            this.panelAppliedPosition0.Name = "panelAppliedPosition0";
            this.panelAppliedPosition0.Size = new System.Drawing.Size(210, 80);
            this.panelAppliedPosition0.TabIndex = 13;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.lblPosition.Location = new System.Drawing.Point(10, 14);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(31, 25);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "—";
            // 
            // lblAppliedPosition
            // 
            this.lblAppliedPosition.AutoSize = true;
            this.lblAppliedPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblAppliedPosition.Location = new System.Drawing.Point(12, 52);
            this.lblAppliedPosition.Name = "lblAppliedPosition";
            this.lblAppliedPosition.Size = new System.Drawing.Size(94, 15);
            this.lblAppliedPosition.TabIndex = 1;
            this.lblAppliedPosition.Text = "Applied Position";
            // 
            // panelMissingDocuments
            // 
            this.panelMissingDocuments.BackColor = System.Drawing.Color.White;
            this.panelMissingDocuments.Controls.Add(this.lblMissDocu);
            this.panelMissingDocuments.Controls.Add(this.lblMissingDocuments);
            this.panelMissingDocuments.Location = new System.Drawing.Point(456, 155);
            this.panelMissingDocuments.Name = "panelMissingDocuments";
            this.panelMissingDocuments.Size = new System.Drawing.Size(190, 80);
            this.panelMissingDocuments.TabIndex = 14;
            // 
            // lblMissDocu
            // 
            this.lblMissDocu.AutoSize = true;
            this.lblMissDocu.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissDocu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(10)))));
            this.lblMissDocu.Location = new System.Drawing.Point(10, 8);
            this.lblMissDocu.Name = "lblMissDocu";
            this.lblMissDocu.Size = new System.Drawing.Size(40, 47);
            this.lblMissDocu.TabIndex = 0;
            this.lblMissDocu.Text = "0";
            // 
            // lblMissingDocuments
            // 
            this.lblMissingDocuments.AutoSize = true;
            this.lblMissingDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblMissingDocuments.Location = new System.Drawing.Point(12, 62);
            this.lblMissingDocuments.Name = "lblMissingDocuments";
            this.lblMissingDocuments.Size = new System.Drawing.Size(112, 15);
            this.lblMissingDocuments.TabIndex = 1;
            this.lblMissingDocuments.Text = "Missing Documents";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblWelcome.Location = new System.Drawing.Point(16, 115);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 25);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblApplicantName1
            // 
            this.lblApplicantName1.AutoSize = true;
            this.lblApplicantName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lblApplicantName1.Location = new System.Drawing.Point(109, 115);
            this.lblApplicantName1.Name = "lblApplicantName1";
            this.lblApplicantName1.Size = new System.Drawing.Size(97, 25);
            this.lblApplicantName1.TabIndex = 11;
            this.lblApplicantName1.Text = "Applicant";
            this.lblApplicantName1.Click += new System.EventHandler(this.lblApplicantName1_Click);
            // 
            // lblSectionDocuments
            // 
            this.lblSectionDocuments.AutoSize = true;
            this.lblSectionDocuments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSectionDocuments.Location = new System.Drawing.Point(16, 252);
            this.lblSectionDocuments.Name = "lblSectionDocuments";
            this.lblSectionDocuments.Size = new System.Drawing.Size(148, 19);
            this.lblSectionDocuments.TabIndex = 20;
            this.lblSectionDocuments.Text = "Required Documents";
            // 
            // lblSectionProgress
            // 
            this.lblSectionProgress.AutoSize = true;
            this.lblSectionProgress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSectionProgress.Location = new System.Drawing.Point(440, 252);
            this.lblSectionProgress.Name = "lblSectionProgress";
            this.lblSectionProgress.Size = new System.Drawing.Size(149, 19);
            this.lblSectionProgress.TabIndex = 22;
            this.lblSectionProgress.Text = "Application Progress";
            // 
            // dgvDocumentStatus
            // 
            this.dgvDocumentStatus.AllowUserToAddRows = false;
            this.dgvDocumentStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDocumentStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocType,
            this.colDocStatus});
            this.dgvDocumentStatus.Location = new System.Drawing.Point(16, 275);
            this.dgvDocumentStatus.Name = "dgvDocumentStatus";
            this.dgvDocumentStatus.ReadOnly = true;
            this.dgvDocumentStatus.RowHeadersVisible = false;
            this.dgvDocumentStatus.Size = new System.Drawing.Size(400, 140);
            this.dgvDocumentStatus.TabIndex = 21;
            // 
            // colDocType
            // 
            this.colDocType.HeaderText = "Document";
            this.colDocType.Name = "colDocType";
            this.colDocType.ReadOnly = true;
            this.colDocType.Width = 220;
            // 
            // colDocStatus
            // 
            this.colDocStatus.HeaderText = "Status";
            this.colDocStatus.Name = "colDocStatus";
            this.colDocStatus.ReadOnly = true;
            this.colDocStatus.Width = 160;
            // 
            // dgvApplicationProgress
            // 
            this.dgvApplicationProgress.AllowUserToAddRows = false;
            this.dgvApplicationProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplicationProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStep,
            this.colStepStatus});
            this.dgvApplicationProgress.Location = new System.Drawing.Point(440, 275);
            this.dgvApplicationProgress.Name = "dgvApplicationProgress";
            this.dgvApplicationProgress.ReadOnly = true;
            this.dgvApplicationProgress.RowHeadersVisible = false;
            this.dgvApplicationProgress.Size = new System.Drawing.Size(400, 140);
            this.dgvApplicationProgress.TabIndex = 23;
            // 
            // colStep
            // 
            this.colStep.HeaderText = "Step";
            this.colStep.Name = "colStep";
            this.colStep.ReadOnly = true;
            this.colStep.Width = 250;
            // 
            // colStepStatus
            // 
            this.colStepStatus.HeaderText = "Status";
            this.colStepStatus.Name = "colStepStatus";
            this.colStepStatus.ReadOnly = true;
            this.colStepStatus.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblInterviewSchedule);
            this.panel1.Controls.Add(this.lblInterview);
            this.panel1.Location = new System.Drawing.Point(667, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 110);
            this.panel1.TabIndex = 24;
            // 
            // lblInterviewSchedule
            // 
            this.lblInterviewSchedule.AutoSize = true;
            this.lblInterviewSchedule.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(10)))));
            this.lblInterviewSchedule.Location = new System.Drawing.Point(10, 14);
            this.lblInterviewSchedule.Name = "lblInterviewSchedule";
            this.lblInterviewSchedule.Size = new System.Drawing.Size(89, 47);
            this.lblInterviewSchedule.TabIndex = 0;
            this.lblInterviewSchedule.Text = "0:00";
            // 
            // lblInterview
            // 
            this.lblInterview.AutoSize = true;
            this.lblInterview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblInterview.Location = new System.Drawing.Point(12, 52);
            this.lblInterview.Name = "lblInterview";
            this.lblInterview.Size = new System.Drawing.Size(106, 15);
            this.lblInterview.TabIndex = 1;
            this.lblInterview.Text = "Interview Schedule";
            // 
            // cmbApplicationSelector
            // 
            this.cmbApplicationSelector.FormattingEnabled = true;
            this.cmbApplicationSelector.Location = new System.Drawing.Point(705, 118);
            this.cmbApplicationSelector.Name = "cmbApplicationSelector";
            this.cmbApplicationSelector.Size = new System.Drawing.Size(121, 21);
            this.cmbApplicationSelector.TabIndex = 25;
            this.cmbApplicationSelector.SelectedIndexChanged +=
                new System.EventHandler(this.cmbApplicationSelector_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 460);
            this.Controls.Add(this.cmbApplicationSelector);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvApplicationProgress);
            this.Controls.Add(this.lblSectionProgress);
            this.Controls.Add(this.dgvDocumentStatus);
            this.Controls.Add(this.lblSectionDocuments);
            this.Controls.Add(this.panelMissingDocuments);
            this.Controls.Add(this.panelAppliedPosition0);
            this.Controls.Add(this.panelCardStatus);
            this.Controls.Add(this.lblApplicantName1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashboardpfp)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.panelCardStatus.ResumeLayout(false);
            this.panelCardStatus.PerformLayout();
            this.panelAppliedPosition0.ResumeLayout(false);
            this.panelAppliedPosition0.PerformLayout();
            this.panelMissingDocuments.ResumeLayout(false);
            this.panelMissingDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationProgress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnDashboardClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBoxDashboardpfp;
        private System.Windows.Forms.Label lblApplicantFirstName;
        private System.Windows.Forms.Label lblApplicantLastName;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnJobVacancies;
        private System.Windows.Forms.Button btnMyApplication;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnStatusTracking;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblApplicantName1;
        private System.Windows.Forms.Panel panelCardStatus;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelAppliedPosition0;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAppliedPosition;
        private System.Windows.Forms.Panel panelMissingDocuments;
        private System.Windows.Forms.Label lblMissDocu;
        private System.Windows.Forms.Label lblMissingDocuments;
        private System.Windows.Forms.Label lblSectionDocuments;
        private System.Windows.Forms.Label lblSectionProgress;
        private System.Windows.Forms.DataGridView dgvDocumentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocStatus;
        private System.Windows.Forms.DataGridView dgvApplicationProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStepStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInterviewSchedule;
        private System.Windows.Forms.Label lblInterview;
        private System.Windows.Forms.ComboBox cmbApplicationSelector;
    }
}
