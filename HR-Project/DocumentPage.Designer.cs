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
            this.lblReqAppDoc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMyDocumentsSummary = new System.Windows.Forms.GroupBox();
            this.chkMyDocumentsCertificates = new System.Windows.Forms.CheckBox();
            this.chkMyDocumentsTranscript = new System.Windows.Forms.CheckBox();
            this.chkMyDocumentsGovernmentID = new System.Windows.Forms.CheckBox();
            this.chkMyDocumentsResume = new System.Windows.Forms.CheckBox();
            this.lblMyDocumentsMissingCount = new System.Windows.Forms.Label();
            this.lbMyDocumentslMissingRequirements = new System.Windows.Forms.Label();
            this.lblMyDocumentsSubmittedCount = new System.Windows.Forms.Label();
            this.lblMyDocumentsSubmittedDocuments = new System.Windows.Forms.Label();
            this.grpMyDocumentsSubmissionPanel = new System.Windows.Forms.GroupBox();
            this.btnMyDocumentsUploadFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnMyDocumentsBrowse = new System.Windows.Forms.Button();
            this.txtMyDocumentsFilePath = new System.Windows.Forms.TextBox();
            this.lblMyDocumentsFilePath = new System.Windows.Forms.Label();
            this.cmbMyDocumentsDocuType = new System.Windows.Forms.ComboBox();
            this.lblMyDocumentsSelectDocuType = new System.Windows.Forms.Label();
            this.dgvMyDocumentsStatusTrap = new System.Windows.Forms.DataGridView();
            this.colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMyDocumentsHeader = new System.Windows.Forms.Panel();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.lblMyDocumentsTitle = new System.Windows.Forms.Label();
            this.panelMyDocumentsNavigation = new System.Windows.Forms.Panel();
            this.btnMyDocumentsStatusTracking = new System.Windows.Forms.Button();
            this.btnMyDocumentsDocuments = new System.Windows.Forms.Button();
            this.btnMyDocumentsMyApplication = new System.Windows.Forms.Button();
            this.btnMyDocumentsJobVacancies = new System.Windows.Forms.Button();
            this.btnMyDocumentsMyProfile = new System.Windows.Forms.Button();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.grpMyDocumentsSummary.SuspendLayout();
            this.grpMyDocumentsSubmissionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDocumentsStatusTrap)).BeginInit();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyDocumentsNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReqAppDoc
            // 
            this.lblReqAppDoc.AutoSize = true;
            this.lblReqAppDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblReqAppDoc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqAppDoc.Location = new System.Drawing.Point(37, 167);
            this.lblReqAppDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReqAppDoc.Name = "lblReqAppDoc";
            this.lblReqAppDoc.Size = new System.Drawing.Size(354, 30);
            this.lblReqAppDoc.TabIndex = 7;
            this.lblReqAppDoc.Text = "Required Application Documents";
            this.lblReqAppDoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpMyDocumentsSummary
            // 
            this.grpMyDocumentsSummary.BackColor = System.Drawing.Color.Transparent;
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsCertificates);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsTranscript);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsGovernmentID);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsResume);
            this.grpMyDocumentsSummary.Controls.Add(this.lblMyDocumentsMissingCount);
            this.grpMyDocumentsSummary.Controls.Add(this.lbMyDocumentslMissingRequirements);
            this.grpMyDocumentsSummary.Controls.Add(this.lblMyDocumentsSubmittedCount);
            this.grpMyDocumentsSummary.Controls.Add(this.lblMyDocumentsSubmittedDocuments);
            this.grpMyDocumentsSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMyDocumentsSummary.Location = new System.Drawing.Point(433, 148);
            this.grpMyDocumentsSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpMyDocumentsSummary.Name = "grpMyDocumentsSummary";
            this.grpMyDocumentsSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpMyDocumentsSummary.Size = new System.Drawing.Size(431, 133);
            this.grpMyDocumentsSummary.TabIndex = 8;
            this.grpMyDocumentsSummary.TabStop = false;
            this.grpMyDocumentsSummary.Text = "Document Compliance Summary";
            // 
            // chkMyDocumentsCertificates
            // 
            this.chkMyDocumentsCertificates.AutoSize = true;
            this.chkMyDocumentsCertificates.Enabled = false;
            this.chkMyDocumentsCertificates.Location = new System.Drawing.Point(276, 96);
            this.chkMyDocumentsCertificates.Name = "chkMyDocumentsCertificates";
            this.chkMyDocumentsCertificates.Size = new System.Drawing.Size(90, 19);
            this.chkMyDocumentsCertificates.TabIndex = 8;
            this.chkMyDocumentsCertificates.Text = "Certificates";
            this.chkMyDocumentsCertificates.UseVisualStyleBackColor = true;
            // 
            // chkMyDocumentsTranscript
            // 
            this.chkMyDocumentsTranscript.AutoSize = true;
            this.chkMyDocumentsTranscript.Enabled = false;
            this.chkMyDocumentsTranscript.Location = new System.Drawing.Point(275, 71);
            this.chkMyDocumentsTranscript.Name = "chkMyDocumentsTranscript";
            this.chkMyDocumentsTranscript.Size = new System.Drawing.Size(81, 19);
            this.chkMyDocumentsTranscript.TabIndex = 7;
            this.chkMyDocumentsTranscript.Text = "Transcript";
            this.chkMyDocumentsTranscript.UseVisualStyleBackColor = true;
            // 
            // chkMyDocumentsGovernmentID
            // 
            this.chkMyDocumentsGovernmentID.AutoSize = true;
            this.chkMyDocumentsGovernmentID.Enabled = false;
            this.chkMyDocumentsGovernmentID.Location = new System.Drawing.Point(275, 46);
            this.chkMyDocumentsGovernmentID.Name = "chkMyDocumentsGovernmentID";
            this.chkMyDocumentsGovernmentID.Size = new System.Drawing.Size(111, 19);
            this.chkMyDocumentsGovernmentID.TabIndex = 6;
            this.chkMyDocumentsGovernmentID.Text = "GovernmentID";
            this.chkMyDocumentsGovernmentID.UseVisualStyleBackColor = true;
            // 
            // chkMyDocumentsResume
            // 
            this.chkMyDocumentsResume.AutoSize = true;
            this.chkMyDocumentsResume.Enabled = false;
            this.chkMyDocumentsResume.Location = new System.Drawing.Point(275, 21);
            this.chkMyDocumentsResume.Name = "chkMyDocumentsResume";
            this.chkMyDocumentsResume.Size = new System.Drawing.Size(91, 19);
            this.chkMyDocumentsResume.TabIndex = 5;
            this.chkMyDocumentsResume.Text = "Resume/CV";
            this.chkMyDocumentsResume.UseVisualStyleBackColor = true;
            // 
            // lblMyDocumentsMissingCount
            // 
            this.lblMyDocumentsMissingCount.AutoSize = true;
            this.lblMyDocumentsMissingCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsMissingCount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMyDocumentsMissingCount.Location = new System.Drawing.Point(180, 60);
            this.lblMyDocumentsMissingCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDocumentsMissingCount.Name = "lblMyDocumentsMissingCount";
            this.lblMyDocumentsMissingCount.Size = new System.Drawing.Size(18, 20);
            this.lblMyDocumentsMissingCount.TabIndex = 3;
            this.lblMyDocumentsMissingCount.Text = "0";
            // 
            // lbMyDocumentslMissingRequirements
            // 
            this.lbMyDocumentslMissingRequirements.AutoSize = true;
            this.lbMyDocumentslMissingRequirements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyDocumentslMissingRequirements.Location = new System.Drawing.Point(13, 60);
            this.lbMyDocumentslMissingRequirements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMyDocumentslMissingRequirements.Name = "lbMyDocumentslMissingRequirements";
            this.lbMyDocumentslMissingRequirements.Size = new System.Drawing.Size(169, 20);
            this.lbMyDocumentslMissingRequirements.TabIndex = 2;
            this.lbMyDocumentslMissingRequirements.Text = "Missing Requirements:";
            this.lbMyDocumentslMissingRequirements.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMyDocumentsSubmittedCount
            // 
            this.lblMyDocumentsSubmittedCount.AutoSize = true;
            this.lblMyDocumentsSubmittedCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsSubmittedCount.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblMyDocumentsSubmittedCount.Location = new System.Drawing.Point(180, 27);
            this.lblMyDocumentsSubmittedCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDocumentsSubmittedCount.Name = "lblMyDocumentsSubmittedCount";
            this.lblMyDocumentsSubmittedCount.Size = new System.Drawing.Size(18, 20);
            this.lblMyDocumentsSubmittedCount.TabIndex = 1;
            this.lblMyDocumentsSubmittedCount.Text = "0";
            // 
            // lblMyDocumentsSubmittedDocuments
            // 
            this.lblMyDocumentsSubmittedDocuments.AutoSize = true;
            this.lblMyDocumentsSubmittedDocuments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsSubmittedDocuments.Location = new System.Drawing.Point(11, 27);
            this.lblMyDocumentsSubmittedDocuments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDocumentsSubmittedDocuments.Name = "lblMyDocumentsSubmittedDocuments";
            this.lblMyDocumentsSubmittedDocuments.Size = new System.Drawing.Size(170, 20);
            this.lblMyDocumentsSubmittedDocuments.TabIndex = 0;
            this.lblMyDocumentsSubmittedDocuments.Text = "Submitted Documents:";
            // 
            // grpMyDocumentsSubmissionPanel
            // 
            this.grpMyDocumentsSubmissionPanel.BackColor = System.Drawing.Color.Transparent;
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.btnMyDocumentsUploadFile);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.button2);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.txtRemarks);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.lblRemarks);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.btnMyDocumentsBrowse);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.txtMyDocumentsFilePath);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.lblMyDocumentsFilePath);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.cmbMyDocumentsDocuType);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.lblMyDocumentsSelectDocuType);
            this.grpMyDocumentsSubmissionPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMyDocumentsSubmissionPanel.Location = new System.Drawing.Point(11, 285);
            this.grpMyDocumentsSubmissionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.grpMyDocumentsSubmissionPanel.Name = "grpMyDocumentsSubmissionPanel";
            this.grpMyDocumentsSubmissionPanel.Padding = new System.Windows.Forms.Padding(2);
            this.grpMyDocumentsSubmissionPanel.Size = new System.Drawing.Size(523, 87);
            this.grpMyDocumentsSubmissionPanel.TabIndex = 9;
            this.grpMyDocumentsSubmissionPanel.TabStop = false;
            this.grpMyDocumentsSubmissionPanel.Text = "Submission Control Panel";
            // 
            // btnMyDocumentsUploadFile
            // 
            this.btnMyDocumentsUploadFile.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMyDocumentsUploadFile.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsUploadFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyDocumentsUploadFile.Location = new System.Drawing.Point(291, 54);
            this.btnMyDocumentsUploadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyDocumentsUploadFile.Name = "btnMyDocumentsUploadFile";
            this.btnMyDocumentsUploadFile.Size = new System.Drawing.Size(51, 27);
            this.btnMyDocumentsUploadFile.TabIndex = 8;
            this.btnMyDocumentsUploadFile.Text = "Upload File";
            this.btnMyDocumentsUploadFile.UseVisualStyleBackColor = false;
            this.btnMyDocumentsUploadFile.Click += new System.EventHandler(this.btnMyDocumentsUploadFile_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(323, 109);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Upload File";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(133, 86);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(130, 22);
            this.txtRemarks.TabIndex = 6;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(11, 86);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(114, 15);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Applicant Remarks:";
            // 
            // btnMyDocumentsBrowse
            // 
            this.btnMyDocumentsBrowse.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsBrowse.Location = new System.Drawing.Point(207, 56);
            this.btnMyDocumentsBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyDocumentsBrowse.Name = "btnMyDocumentsBrowse";
            this.btnMyDocumentsBrowse.Size = new System.Drawing.Size(55, 19);
            this.btnMyDocumentsBrowse.TabIndex = 4;
            this.btnMyDocumentsBrowse.Text = "Browse...";
            this.btnMyDocumentsBrowse.UseVisualStyleBackColor = true;
            this.btnMyDocumentsBrowse.Click += new System.EventHandler(this.btnMyDocumentsBrowse_Click);
            // 
            // txtMyDocumentsFilePath
            // 
            this.txtMyDocumentsFilePath.Location = new System.Drawing.Point(75, 57);
            this.txtMyDocumentsFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtMyDocumentsFilePath.Name = "txtMyDocumentsFilePath";
            this.txtMyDocumentsFilePath.ReadOnly = true;
            this.txtMyDocumentsFilePath.Size = new System.Drawing.Size(130, 23);
            this.txtMyDocumentsFilePath.TabIndex = 3;
            // 
            // lblMyDocumentsFilePath
            // 
            this.lblMyDocumentsFilePath.AutoSize = true;
            this.lblMyDocumentsFilePath.Location = new System.Drawing.Point(11, 57);
            this.lblMyDocumentsFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDocumentsFilePath.Name = "lblMyDocumentsFilePath";
            this.lblMyDocumentsFilePath.Size = new System.Drawing.Size(57, 15);
            this.lblMyDocumentsFilePath.TabIndex = 2;
            this.lblMyDocumentsFilePath.Text = "File Path:";
            // 
            // cmbMyDocumentsDocuType
            // 
            this.cmbMyDocumentsDocuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyDocumentsDocuType.FormattingEnabled = true;
            this.cmbMyDocumentsDocuType.Items.AddRange(new object[] {
            "Resume/CV\n",
            "Government ID\n",
            "Transcript",
            "\nCertificates"});
            this.cmbMyDocumentsDocuType.Location = new System.Drawing.Point(153, 28);
            this.cmbMyDocumentsDocuType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMyDocumentsDocuType.Name = "cmbMyDocumentsDocuType";
            this.cmbMyDocumentsDocuType.Size = new System.Drawing.Size(111, 23);
            this.cmbMyDocumentsDocuType.TabIndex = 1;
            this.cmbMyDocumentsDocuType.SelectedIndexChanged += new System.EventHandler(this.cmbMyDocumentsDocuType_SelectedIndexChanged);
            // 
            // lblMyDocumentsSelectDocuType
            // 
            this.lblMyDocumentsSelectDocuType.AutoSize = true;
            this.lblMyDocumentsSelectDocuType.Location = new System.Drawing.Point(11, 28);
            this.lblMyDocumentsSelectDocuType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyDocumentsSelectDocuType.Name = "lblMyDocumentsSelectDocuType";
            this.lblMyDocumentsSelectDocuType.Size = new System.Drawing.Size(136, 15);
            this.lblMyDocumentsSelectDocuType.TabIndex = 0;
            this.lblMyDocumentsSelectDocuType.Text = "Select Document Type:";
            // 
            // dgvMyDocumentsStatusTrap
            // 
            this.dgvMyDocumentsStatusTrap.AllowUserToAddRows = false;
            this.dgvMyDocumentsStatusTrap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyDocumentsStatusTrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyDocumentsStatusTrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocType,
            this.colStatus,
            this.colRemarks,
            this.colFileName});
            this.dgvMyDocumentsStatusTrap.Location = new System.Drawing.Point(7, 404);
            this.dgvMyDocumentsStatusTrap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMyDocumentsStatusTrap.Name = "dgvMyDocumentsStatusTrap";
            this.dgvMyDocumentsStatusTrap.ReadOnly = true;
            this.dgvMyDocumentsStatusTrap.RowHeadersWidth = 62;
            this.dgvMyDocumentsStatusTrap.RowTemplate.Height = 28;
            this.dgvMyDocumentsStatusTrap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyDocumentsStatusTrap.Size = new System.Drawing.Size(494, 97);
            this.dgvMyDocumentsStatusTrap.TabIndex = 10;
            // 
            // colDocType
            // 
            this.colDocType.DataPropertyName = "DocumentType";
            this.colDocType.HeaderText = "Document Type";
            this.colDocType.MinimumWidth = 8;
            this.colDocType.Name = "colDocType";
            this.colDocType.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colRemarks
            // 
            this.colRemarks.DataPropertyName = "Remarks";
            this.colRemarks.HeaderText = "HR Remarks";
            this.colRemarks.MinimumWidth = 8;
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "FileName";
            this.colFileName.HeaderText = "File Name";
            this.colFileName.MinimumWidth = 8;
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 15);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(864, 60);
            this.panelMyDocumentsHeader.TabIndex = 12;
            this.panelMyDocumentsHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProfilePageHeader_Paint);
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
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = true;
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(3, 23);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(140, 20);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "My Documents";
            // 
            // panelMyDocumentsNavigation
            // 
            this.panelMyDocumentsNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsStatusTracking);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDocuments);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsMyApplication);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsJobVacancies);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsMyProfile);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyDocumentsNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelMyDocumentsNavigation.Name = "panelMyDocumentsNavigation";
            this.panelMyDocumentsNavigation.Size = new System.Drawing.Size(869, 42);
            this.panelMyDocumentsNavigation.TabIndex = 13;
            // 
            // btnMyDocumentsStatusTracking
            // 
            this.btnMyDocumentsStatusTracking.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsStatusTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsStatusTracking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsStatusTracking.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsStatusTracking.Location = new System.Drawing.Point(669, 9);
            this.btnMyDocumentsStatusTracking.Name = "btnMyDocumentsStatusTracking";
            this.btnMyDocumentsStatusTracking.Size = new System.Drawing.Size(96, 23);
            this.btnMyDocumentsStatusTracking.TabIndex = 3;
            this.btnMyDocumentsStatusTracking.Text = "Status Tracking";
            this.btnMyDocumentsStatusTracking.UseVisualStyleBackColor = false;
            // 
            // btnMyDocumentsDocuments
            // 
            this.btnMyDocumentsDocuments.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDocuments.Enabled = false;
            this.btnMyDocumentsDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsDocuments.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDocuments.Location = new System.Drawing.Point(539, 9);
            this.btnMyDocumentsDocuments.Name = "btnMyDocumentsDocuments";
            this.btnMyDocumentsDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsDocuments.TabIndex = 2;
            this.btnMyDocumentsDocuments.Text = "Documents";
            this.btnMyDocumentsDocuments.UseVisualStyleBackColor = false;
            // 
            // btnMyDocumentsMyApplication
            // 
            this.btnMyDocumentsMyApplication.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsMyApplication.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsMyApplication.Location = new System.Drawing.Point(402, 9);
            this.btnMyDocumentsMyApplication.Name = "btnMyDocumentsMyApplication";
            this.btnMyDocumentsMyApplication.Size = new System.Drawing.Size(89, 23);
            this.btnMyDocumentsMyApplication.TabIndex = 2;
            this.btnMyDocumentsMyApplication.Text = "My Application";
            this.btnMyDocumentsMyApplication.UseVisualStyleBackColor = false;
            this.btnMyDocumentsMyApplication.Click += new System.EventHandler(this.btnMyDocumentsMyApplication_Click);
            // 
            // btnMyDocumentsJobVacancies
            // 
            this.btnMyDocumentsJobVacancies.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsJobVacancies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsJobVacancies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsJobVacancies.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsJobVacancies.Location = new System.Drawing.Point(265, 9);
            this.btnMyDocumentsJobVacancies.Name = "btnMyDocumentsJobVacancies";
            this.btnMyDocumentsJobVacancies.Size = new System.Drawing.Size(89, 23);
            this.btnMyDocumentsJobVacancies.TabIndex = 2;
            this.btnMyDocumentsJobVacancies.Text = "Job Vacancies";
            this.btnMyDocumentsJobVacancies.UseVisualStyleBackColor = false;
            this.btnMyDocumentsJobVacancies.Click += new System.EventHandler(this.btnMyDocumentsJobVacancies_Click);
            // 
            // btnMyDocumentsMyProfile
            // 
            this.btnMyDocumentsMyProfile.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsMyProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsMyProfile.Location = new System.Drawing.Point(149, 9);
            this.btnMyDocumentsMyProfile.Name = "btnMyDocumentsMyProfile";
            this.btnMyDocumentsMyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsMyProfile.TabIndex = 1;
            this.btnMyDocumentsMyProfile.Text = "My Profile";
            this.btnMyDocumentsMyProfile.UseVisualStyleBackColor = false;
            this.btnMyDocumentsMyProfile.Click += new System.EventHandler(this.btnMyDocumentsMyProfile_Click);
            // 
            // btnMyDocumentsDashboard
            // 
            this.btnMyDocumentsDashboard.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.panelMyDocumentsNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvMyDocumentsStatusTrap);
            this.Controls.Add(this.grpMyDocumentsSubmissionPanel);
            this.Controls.Add(this.grpMyDocumentsSummary);
            this.Controls.Add(this.lblReqAppDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocumentPage";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMyDocumentsSummary.ResumeLayout(false);
            this.grpMyDocumentsSummary.PerformLayout();
            this.grpMyDocumentsSubmissionPanel.ResumeLayout(false);
            this.grpMyDocumentsSubmissionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDocumentsStatusTrap)).EndInit();
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyDocumentsNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReqAppDoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpMyDocumentsSummary;
        private System.Windows.Forms.Label lblMyDocumentsSubmittedDocuments;
        private System.Windows.Forms.Label lblMyDocumentsSubmittedCount;
        private System.Windows.Forms.Label lbMyDocumentslMissingRequirements;
        private System.Windows.Forms.Label lblMyDocumentsMissingCount;
        private System.Windows.Forms.GroupBox grpMyDocumentsSubmissionPanel;
        private System.Windows.Forms.Label lblMyDocumentsSelectDocuType;
        private System.Windows.Forms.TextBox txtMyDocumentsFilePath;
        private System.Windows.Forms.Label lblMyDocumentsFilePath;
        private System.Windows.Forms.ComboBox cmbMyDocumentsDocuType;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnMyDocumentsBrowse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvMyDocumentsStatusTrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.Button btnMyDocumentsUploadFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelMyDocumentsHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblMyDocumentsTitle;
        private System.Windows.Forms.Panel panelMyDocumentsNavigation;
        private System.Windows.Forms.Button btnMyDocumentsStatusTracking;
        private System.Windows.Forms.Button btnMyDocumentsDocuments;
        private System.Windows.Forms.Button btnMyDocumentsMyApplication;
        private System.Windows.Forms.Button btnMyDocumentsJobVacancies;
        private System.Windows.Forms.Button btnMyDocumentsMyProfile;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.CheckBox chkMyDocumentsCertificates;
        private System.Windows.Forms.CheckBox chkMyDocumentsTranscript;
        private System.Windows.Forms.CheckBox chkMyDocumentsGovernmentID;
        private System.Windows.Forms.CheckBox chkMyDocumentsResume;
    }
}

