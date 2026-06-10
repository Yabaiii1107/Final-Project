namespace HR_Project.HR_System
{
    partial class JobVacancyManagement
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
            this.tabGeneraIInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCloseJOb = new System.Windows.Forms.Button();
            this.btnActiveJob = new System.Windows.Forms.Button();
            this.lblStatusLifecycleControl = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lstQualifications = new System.Windows.Forms.ListBox();
            this.btnAddQual = new System.Windows.Forms.Button();
            this.lblQualifications = new System.Windows.Forms.Label();
            this.txtQualInfo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblReqDocu = new System.Windows.Forms.Label();
            this.chkCertificates = new System.Windows.Forms.CheckBox();
            this.chkGovernmentID = new System.Windows.Forms.CheckBox();
            this.chkTranscript = new System.Windows.Forms.CheckBox();
            this.chkResume = new System.Windows.Forms.CheckBox();
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActiveOpeningList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveJobOpening = new System.Windows.Forms.Button();
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblWelcomeHR = new System.Windows.Forms.Label();
            this.cmbEmploymentType = new System.Windows.Forms.ComboBox();
            this.lblEmploymentType = new System.Windows.Forms.Label();
            this.tabGeneraIInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneraIInfo
            // 
            this.tabGeneraIInfo.Controls.Add(this.tabPage1);
            this.tabGeneraIInfo.Controls.Add(this.tabPage2);
            this.tabGeneraIInfo.Controls.Add(this.tabPage3);
            this.tabGeneraIInfo.Location = new System.Drawing.Point(26, 190);
            this.tabGeneraIInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabGeneraIInfo.Name = "tabGeneraIInfo";
            this.tabGeneraIInfo.SelectedIndex = 0;
            this.tabGeneraIInfo.Size = new System.Drawing.Size(355, 235);
            this.tabGeneraIInfo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tabPage1.BackgroundImage = global::HR_Project.Properties.Resources.download__70_;
            this.tabPage1.Controls.Add(this.lblEmploymentType);
            this.tabPage1.Controls.Add(this.cmbEmploymentType);
            this.tabPage1.Controls.Add(this.btnCloseJOb);
            this.tabPage1.Controls.Add(this.btnActiveJob);
            this.tabPage1.Controls.Add(this.lblStatusLifecycleControl);
            this.tabPage1.Controls.Add(this.cmbDepartment);
            this.tabPage1.Controls.Add(this.lblDepartment);
            this.tabPage1.Controls.Add(this.lblJobTitle);
            this.tabPage1.Controls.Add(this.txtJobTitle);
            this.tabPage1.ForeColor = System.Drawing.Color.OliveDrab;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(347, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Information";
            // 
            // btnCloseJOb
            // 
            this.btnCloseJOb.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseJOb.BackgroundImage = global::HR_Project.Properties.Resources.download__70_;
            this.btnCloseJOb.ForeColor = System.Drawing.Color.Black;
            this.btnCloseJOb.Location = new System.Drawing.Point(147, 162);
            this.btnCloseJOb.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseJOb.Name = "btnCloseJOb";
            this.btnCloseJOb.Size = new System.Drawing.Size(94, 23);
            this.btnCloseJOb.TabIndex = 6;
            this.btnCloseJOb.Text = "Close Vacancy";
            this.btnCloseJOb.UseVisualStyleBackColor = false;
            this.btnCloseJOb.Click += new System.EventHandler(this.btnCloseJOb_Click);
            // 
            // btnActiveJob
            // 
            this.btnActiveJob.BackColor = System.Drawing.Color.Transparent;
            this.btnActiveJob.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.btnActiveJob.ForeColor = System.Drawing.Color.Black;
            this.btnActiveJob.Location = new System.Drawing.Point(19, 162);
            this.btnActiveJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnActiveJob.Name = "btnActiveJob";
            this.btnActiveJob.Size = new System.Drawing.Size(94, 23);
            this.btnActiveJob.TabIndex = 5;
            this.btnActiveJob.Text = "Reopen/Activate";
            this.btnActiveJob.UseVisualStyleBackColor = false;
            this.btnActiveJob.Click += new System.EventHandler(this.btnActiveJob_Click);
            // 
            // lblStatusLifecycleControl
            // 
            this.lblStatusLifecycleControl.AutoSize = true;
            this.lblStatusLifecycleControl.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusLifecycleControl.ForeColor = System.Drawing.Color.Black;
            this.lblStatusLifecycleControl.Location = new System.Drawing.Point(16, 132);
            this.lblStatusLifecycleControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusLifecycleControl.Name = "lblStatusLifecycleControl";
            this.lblStatusLifecycleControl.Size = new System.Drawing.Size(121, 13);
            this.lblStatusLifecycleControl.TabIndex = 4;
            this.lblStatusLifecycleControl.Text = "Status Lifecycle Control:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.White;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Human Resources",
            "Information Technology",
            "Finance",
            "Accounting",
            "Marketing",
            "Sales",
            "Operations",
            "Customer Service",
            "Administration",
            "Procurement",
            "Engineering",
            "Research and Development",
            "Legal",
            "Logistics",
            "Production",
            "Quality Assurance",
            "Training and Development",
            "Business Development"});
            this.cmbDepartment.Location = new System.Drawing.Point(82, 60);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(160, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(16, 60);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblJobTitle.ForeColor = System.Drawing.Color.Black;
            this.lblJobTitle.Location = new System.Drawing.Point(16, 36);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(51, 13);
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "Job TItle:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(69, 36);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(173, 20);
            this.txtJobTitle.TabIndex = 2;
            this.txtJobTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJobTitle_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage2.BackgroundImage = global::HR_Project.Properties.Resources.download__70_;
            this.tabPage2.Controls.Add(this.lblQualification);
            this.tabPage2.Controls.Add(this.lstQualifications);
            this.tabPage2.Controls.Add(this.btnAddQual);
            this.tabPage2.Controls.Add(this.lblQualifications);
            this.tabPage2.Controls.Add(this.txtQualInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(347, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Qualifications";
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblQualification.ForeColor = System.Drawing.Color.Black;
            this.lblQualification.Location = new System.Drawing.Point(20, 29);
            this.lblQualification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(73, 13);
            this.lblQualification.TabIndex = 4;
            this.lblQualification.Text = "Qualifications:";
            // 
            // lstQualifications
            // 
            this.lstQualifications.FormattingEnabled = true;
            this.lstQualifications.Location = new System.Drawing.Point(19, 80);
            this.lstQualifications.Margin = new System.Windows.Forms.Padding(2);
            this.lstQualifications.Name = "lstQualifications";
            this.lstQualifications.Size = new System.Drawing.Size(144, 108);
            this.lstQualifications.TabIndex = 3;
            // 
            // btnAddQual
            // 
            this.btnAddQual.ForeColor = System.Drawing.Color.Black;
            this.btnAddQual.Location = new System.Drawing.Point(187, 42);
            this.btnAddQual.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQual.Name = "btnAddQual";
            this.btnAddQual.Size = new System.Drawing.Size(106, 19);
            this.btnAddQual.TabIndex = 2;
            this.btnAddQual.Text = "Add Requirement";
            this.btnAddQual.UseVisualStyleBackColor = true;
            this.btnAddQual.Click += new System.EventHandler(this.btnAddQual_Click);
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.BackColor = System.Drawing.Color.Transparent;
            this.lblQualifications.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifications.ForeColor = System.Drawing.Color.Black;
            this.lblQualifications.Location = new System.Drawing.Point(16, 22);
            this.lblQualifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(0, 13);
            this.lblQualifications.TabIndex = 1;
            // 
            // txtQualInfo
            // 
            this.txtQualInfo.Location = new System.Drawing.Point(19, 44);
            this.txtQualInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtQualInfo.Name = "txtQualInfo";
            this.txtQualInfo.Size = new System.Drawing.Size(144, 20);
            this.txtQualInfo.TabIndex = 0;
            this.txtQualInfo.TextChanged += new System.EventHandler(this.txtQualInfo_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::HR_Project.Properties.Resources.download__70_;
            this.tabPage3.Controls.Add(this.lblReqDocu);
            this.tabPage3.Controls.Add(this.chkCertificates);
            this.tabPage3.Controls.Add(this.chkGovernmentID);
            this.tabPage3.Controls.Add(this.chkTranscript);
            this.tabPage3.Controls.Add(this.chkResume);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(347, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Documents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblReqDocu
            // 
            this.lblReqDocu.AutoSize = true;
            this.lblReqDocu.ForeColor = System.Drawing.Color.Black;
            this.lblReqDocu.Location = new System.Drawing.Point(27, 15);
            this.lblReqDocu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReqDocu.Name = "lblReqDocu";
            this.lblReqDocu.Size = new System.Drawing.Size(110, 13);
            this.lblReqDocu.TabIndex = 4;
            this.lblReqDocu.Text = "Required Documents:";
            // 
            // chkCertificates
            // 
            this.chkCertificates.AutoSize = true;
            this.chkCertificates.ForeColor = System.Drawing.Color.Black;
            this.chkCertificates.Location = new System.Drawing.Point(30, 124);
            this.chkCertificates.Margin = new System.Windows.Forms.Padding(2);
            this.chkCertificates.Name = "chkCertificates";
            this.chkCertificates.Size = new System.Drawing.Size(78, 17);
            this.chkCertificates.TabIndex = 3;
            this.chkCertificates.Text = "Certificates";
            this.chkCertificates.UseVisualStyleBackColor = true;
            // 
            // chkGovernmentID
            // 
            this.chkGovernmentID.AutoSize = true;
            this.chkGovernmentID.ForeColor = System.Drawing.Color.Black;
            this.chkGovernmentID.Location = new System.Drawing.Point(30, 66);
            this.chkGovernmentID.Margin = new System.Windows.Forms.Padding(2);
            this.chkGovernmentID.Name = "chkGovernmentID";
            this.chkGovernmentID.Size = new System.Drawing.Size(98, 17);
            this.chkGovernmentID.TabIndex = 2;
            this.chkGovernmentID.Text = "Government ID";
            this.chkGovernmentID.UseVisualStyleBackColor = true;
            // 
            // chkTranscript
            // 
            this.chkTranscript.AutoSize = true;
            this.chkTranscript.ForeColor = System.Drawing.Color.Black;
            this.chkTranscript.Location = new System.Drawing.Point(30, 97);
            this.chkTranscript.Margin = new System.Windows.Forms.Padding(2);
            this.chkTranscript.Name = "chkTranscript";
            this.chkTranscript.Size = new System.Drawing.Size(73, 17);
            this.chkTranscript.TabIndex = 1;
            this.chkTranscript.Text = "Transcript";
            this.chkTranscript.UseVisualStyleBackColor = true;
            this.chkTranscript.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkResume
            // 
            this.chkResume.AutoSize = true;
            this.chkResume.ForeColor = System.Drawing.Color.Black;
            this.chkResume.Location = new System.Drawing.Point(30, 40);
            this.chkResume.Margin = new System.Windows.Forms.Padding(2);
            this.chkResume.Name = "chkResume";
            this.chkResume.Size = new System.Drawing.Size(65, 17);
            this.chkResume.TabIndex = 0;
            this.chkResume.Text = "Resume";
            this.chkResume.UseVisualStyleBackColor = true;
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.AllowUserToAddRows = false;
            this.dgvVacancies.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmTitle,
            this.clmStatus});
            this.dgvVacancies.Location = new System.Drawing.Point(441, 209);
            this.dgvVacancies.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.ReadOnly = true;
            this.dgvVacancies.RowHeadersWidth = 62;
            this.dgvVacancies.RowTemplate.Height = 28;
            this.dgvVacancies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacancies.Size = new System.Drawing.Size(318, 216);
            this.dgvVacancies.TabIndex = 2;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 8;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 150;
            // 
            // clmTitle
            // 
            this.clmTitle.HeaderText = "TItle";
            this.clmTitle.MinimumWidth = 8;
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            this.clmTitle.Width = 150;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.MinimumWidth = 8;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 150;
            // 
            // lblActiveOpeningList
            // 
            this.lblActiveOpeningList.AutoSize = true;
            this.lblActiveOpeningList.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveOpeningList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveOpeningList.ForeColor = System.Drawing.Color.Black;
            this.lblActiveOpeningList.Location = new System.Drawing.Point(438, 173);
            this.lblActiveOpeningList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveOpeningList.Name = "lblActiveOpeningList";
            this.lblActiveOpeningList.Size = new System.Drawing.Size(134, 15);
            this.lblActiveOpeningList.TabIndex = 3;
            this.lblActiveOpeningList.Text = "📋 Active Openings List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "📑 Job Opening Configuration Engine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveJobOpening
            // 
            this.btnSaveJobOpening.Location = new System.Drawing.Point(616, 429);
            this.btnSaveJobOpening.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveJobOpening.Name = "btnSaveJobOpening";
            this.btnSaveJobOpening.Size = new System.Drawing.Size(143, 23);
            this.btnSaveJobOpening.TabIndex = 5;
            this.btnSaveJobOpening.Text = "💾 Save Configuration";
            this.btnSaveJobOpening.UseVisualStyleBackColor = true;
            this.btnSaveJobOpening.Click += new System.EventHandler(this.btnSaveJobOpening_Click);
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
            this.panelHeader.TabIndex = 14;
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
            this.btnMyDocumentsLogout.ForeColor = System.Drawing.Color.Black;
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
            this.lblTitle.Size = new System.Drawing.Size(241, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Job Vacancy Management";
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
            this.panelNavigation.Controls.Add(this.btnDashboard);
            this.panelNavigation.Location = new System.Drawing.Point(0, 52);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 42);
            this.panelNavigation.TabIndex = 15;
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
            this.btnApplicants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnApplicants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplicants.ForeColor = System.Drawing.Color.Transparent;
            this.btnApplicants.Location = new System.Drawing.Point(244, 9);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(89, 23);
            this.btnApplicants.TabIndex = 2;
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.UseVisualStyleBackColor = false;
            this.btnApplicants.Click += new System.EventHandler(this.btnApplicants_Click);
            // 
            // btnJobVacanciesManagement
            // 
            this.btnJobVacanciesManagement.BackColor = System.Drawing.Color.Blue;
            this.btnJobVacanciesManagement.Enabled = false;
            this.btnJobVacanciesManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnJobVacanciesManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnJobVacanciesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobVacanciesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobVacanciesManagement.ForeColor = System.Drawing.Color.Transparent;
            this.btnJobVacanciesManagement.Location = new System.Drawing.Point(122, 9);
            this.btnJobVacanciesManagement.Name = "btnJobVacanciesManagement";
            this.btnJobVacanciesManagement.Size = new System.Drawing.Size(100, 23);
            this.btnJobVacanciesManagement.TabIndex = 1;
            this.btnJobVacanciesManagement.Text = "Job Vacancies";
            this.btnJobVacanciesManagement.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Blue;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(12, 9);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(85, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblWelcomeHR
            // 
            this.lblWelcomeHR.AutoSize = true;
            this.lblWelcomeHR.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeHR.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcomeHR.Location = new System.Drawing.Point(26, 123);
            this.lblWelcomeHR.Name = "lblWelcomeHR";
            this.lblWelcomeHR.Size = new System.Drawing.Size(241, 20);
            this.lblWelcomeHR.TabIndex = 18;
            this.lblWelcomeHR.Text = "Job Vacancy Management";
            this.lblWelcomeHR.Click += new System.EventHandler(this.lblWelcomeHR_Click);
            // 
            // cmbEmploymentType
            // 
            this.cmbEmploymentType.FormattingEnabled = true;
            this.cmbEmploymentType.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time",
            "Contract",
            "Internship",
            "Temporary"});
            this.cmbEmploymentType.Location = new System.Drawing.Point(121, 98);
            this.cmbEmploymentType.Name = "cmbEmploymentType";
            this.cmbEmploymentType.Size = new System.Drawing.Size(121, 21);
            this.cmbEmploymentType.TabIndex = 7;
            // 
            // lblEmploymentType
            // 
            this.lblEmploymentType.AutoSize = true;
            this.lblEmploymentType.BackColor = System.Drawing.Color.Transparent;
            this.lblEmploymentType.ForeColor = System.Drawing.Color.Black;
            this.lblEmploymentType.Location = new System.Drawing.Point(19, 98);
            this.lblEmploymentType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmploymentType.Name = "lblEmploymentType";
            this.lblEmploymentType.Size = new System.Drawing.Size(94, 13);
            this.lblEmploymentType.TabIndex = 8;
            this.lblEmploymentType.Text = "Employment Type:";
            // 
            // JobVacancyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.lblWelcomeHR);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSaveJobOpening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActiveOpeningList);
            this.Controls.Add(this.dgvVacancies);
            this.Controls.Add(this.tabGeneraIInfo);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JobVacancyManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabGeneraIInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabGeneraIInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStatusLifecycleControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstQualifications;
        private System.Windows.Forms.Button btnAddQual;
        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.TextBox txtQualInfo;
        private System.Windows.Forms.Button btnCloseJOb;
        private System.Windows.Forms.Button btnActiveJob;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.CheckBox chkGovernmentID;
        private System.Windows.Forms.CheckBox chkTranscript;
        private System.Windows.Forms.CheckBox chkResume;
        private System.Windows.Forms.Label lblReqDocu;
        private System.Windows.Forms.CheckBox chkCertificates;
        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.Label lblActiveOpeningList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveJobOpening;
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblWelcomeHR;
        private System.Windows.Forms.Label lblEmploymentType;
        private System.Windows.Forms.ComboBox cmbEmploymentType;
    }
}

