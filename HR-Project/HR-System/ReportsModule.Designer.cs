namespace HR_ReportsModule
{
    partial class ReportsModule
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
            this.grpReportTypes = new System.Windows.Forms.GroupBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rbAllApplicants = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbInterviews = new System.Windows.Forms.RadioButton();
            this.rbOutcome = new System.Windows.Forms.RadioButton();
            this.rbMissingDocs = new System.Windows.Forms.RadioButton();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDataFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDataTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.dgvReportView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosApplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReportTypes.SuspendLayout();
            this.pnlRadioGroup.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReportTypes
            // 
            this.grpReportTypes.BackColor = System.Drawing.Color.Transparent;
            this.grpReportTypes.Controls.Add(this.pnlRadioGroup);
            this.grpReportTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportTypes.Location = new System.Drawing.Point(49, 137);
            this.grpReportTypes.Name = "grpReportTypes";
            this.grpReportTypes.Size = new System.Drawing.Size(428, 312);
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
            this.pnlRadioGroup.Location = new System.Drawing.Point(6, 39);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(416, 267);
            this.pnlRadioGroup.TabIndex = 0;
            // 
            // rbAllApplicants
            // 
            this.rbAllApplicants.AutoSize = true;
            this.rbAllApplicants.Location = new System.Drawing.Point(24, 21);
            this.rbAllApplicants.Name = "rbAllApplicants";
            this.rbAllApplicants.Size = new System.Drawing.Size(181, 29);
            this.rbAllApplicants.TabIndex = 0;
            this.rbAllApplicants.TabStop = true;
            this.rbAllApplicants.Text = "All Applicant List";
            this.rbAllApplicants.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Location = new System.Drawing.Point(24, 65);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(217, 29);
            this.rbPending.TabIndex = 1;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending Applications";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // rbInterviews
            // 
            this.rbInterviews.AutoSize = true;
            this.rbInterviews.Location = new System.Drawing.Point(24, 116);
            this.rbInterviews.Name = "rbInterviews";
            this.rbInterviews.Size = new System.Drawing.Size(208, 29);
            this.rbInterviews.TabIndex = 2;
            this.rbInterviews.TabStop = true;
            this.rbInterviews.Text = "Interview Schedules";
            this.rbInterviews.UseVisualStyleBackColor = true;
            this.rbInterviews.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbOutcome
            // 
            this.rbOutcome.AutoSize = true;
            this.rbOutcome.Location = new System.Drawing.Point(24, 167);
            this.rbOutcome.Name = "rbOutcome";
            this.rbOutcome.Size = new System.Drawing.Size(209, 29);
            this.rbOutcome.TabIndex = 3;
            this.rbOutcome.TabStop = true;
            this.rbOutcome.Text = "Accepted / Rejected";
            this.rbOutcome.UseVisualStyleBackColor = true;
            // 
            // rbMissingDocs
            // 
            this.rbMissingDocs.AutoSize = true;
            this.rbMissingDocs.Location = new System.Drawing.Point(24, 211);
            this.rbMissingDocs.Name = "rbMissingDocs";
            this.rbMissingDocs.Size = new System.Drawing.Size(225, 29);
            this.rbMissingDocs.TabIndex = 4;
            this.rbMissingDocs.TabStop = true;
            this.rbMissingDocs.Text = "Missing Requirements";
            this.rbMissingDocs.UseVisualStyleBackColor = true;
            // 
            // grpFilters
            // 
            this.grpFilters.BackColor = System.Drawing.Color.Transparent;
            this.grpFilters.Controls.Add(this.btnGenerate);
            this.grpFilters.Controls.Add(this.dtpDataTo);
            this.grpFilters.Controls.Add(this.dtpDataFrom);
            this.grpFilters.Controls.Add(this.lblDateTo);
            this.grpFilters.Controls.Add(this.lblDateFrom);
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilters.Location = new System.Drawing.Point(513, 137);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(632, 312);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "🔍 Dynamic Report Parameters & Filtering Matrix";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(30, 65);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(151, 25);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Filter Date from:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(30, 139);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(128, 25);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "Filter Date to:";
            // 
            // dtpDataFrom
            // 
            this.dtpDataFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFrom.Location = new System.Drawing.Point(187, 60);
            this.dtpDataFrom.Name = "dtpDataFrom";
            this.dtpDataFrom.Size = new System.Drawing.Size(150, 31);
            this.dtpDataFrom.TabIndex = 2;
            // 
            // dtpDataTo
            // 
            this.dtpDataTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTo.Location = new System.Drawing.Point(164, 139);
            this.dtpDataTo.Name = "dtpDataTo";
            this.dtpDataTo.Size = new System.Drawing.Size(173, 31);
            this.dtpDataTo.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(35, 234);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(276, 45);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "⚡ Generate Report Dataset";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.Transparent;
            this.grpOutput.Controls.Add(this.dgvReportView);
            this.grpOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.Location = new System.Drawing.Point(49, 541);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(1096, 221);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "📋 Live Generated Report Output Viewer";
            // 
            // dgvReportView
            // 
            this.dgvReportView.AllowUserToAddRows = false;
            this.dgvReportView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCandidateName,
            this.colPosApplied,
            this.colDataTarget,
            this.colReportStatus});
            this.dgvReportView.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvReportView.Location = new System.Drawing.Point(30, 42);
            this.dgvReportView.Name = "dgvReportView";
            this.dgvReportView.ReadOnly = true;
            this.dgvReportView.RowHeadersWidth = 62;
            this.dgvReportView.RowTemplate.Height = 28;
            this.dgvReportView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportView.Size = new System.Drawing.Size(808, 150);
            this.dgvReportView.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 150;
            // 
            // colCandidateName
            // 
            this.colCandidateName.HeaderText = "Candidate Name";
            this.colCandidateName.MinimumWidth = 8;
            this.colCandidateName.Name = "colCandidateName";
            this.colCandidateName.ReadOnly = true;
            this.colCandidateName.Width = 150;
            // 
            // colPosApplied
            // 
            this.colPosApplied.HeaderText = "Position Applied";
            this.colPosApplied.MinimumWidth = 8;
            this.colPosApplied.Name = "colPosApplied";
            this.colPosApplied.ReadOnly = true;
            this.colPosApplied.Width = 150;
            // 
            // colDataTarget
            // 
            this.colDataTarget.HeaderText = "Data Target";
            this.colDataTarget.MinimumWidth = 8;
            this.colDataTarget.Name = "colDataTarget";
            this.colDataTarget.ReadOnly = true;
            this.colDataTarget.Width = 150;
            // 
            // colReportStatus
            // 
            this.colReportStatus.HeaderText = "Report Status";
            this.colReportStatus.MinimumWidth = 8;
            this.colReportStatus.Name = "colReportStatus";
            this.colReportStatus.ReadOnly = true;
            this.colReportStatus.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_ReportsModule.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(1174, 796);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.grpReportTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpReportTypes.ResumeLayout(false);
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).EndInit();
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
    }
}

