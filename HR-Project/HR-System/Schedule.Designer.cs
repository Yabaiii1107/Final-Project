namespace HR_Project.HR_System
{
    partial class Schedule
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
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.lblPositionApplied = new System.Windows.Forms.Label();
            this.txtPositionApplied = new System.Windows.Forms.TextBox();
            this.lblInterviewDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblInterviewTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblInterviewType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblLocationLink = new System.Windows.Forms.Label();
            this.txtLocationLink = new System.Windows.Forms.TextBox();
            this.lblInterviewer = new System.Windows.Forms.Label();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantName.Location = new System.Drawing.Point(44, 203);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(154, 25);
            this.lblApplicantName.TabIndex = 0;
            this.lblApplicantName.Text = "Applicant Name:";
            this.lblApplicantName.Click += new System.EventHandler(this.lblApplicantName_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(50, 231);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(333, 26);
            this.txtApplicantName.TabIndex = 2;
            // 
            // lblPositionApplied
            // 
            this.lblPositionApplied.AutoSize = true;
            this.lblPositionApplied.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionApplied.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionApplied.Location = new System.Drawing.Point(514, 203);
            this.lblPositionApplied.Name = "lblPositionApplied";
            this.lblPositionApplied.Size = new System.Drawing.Size(156, 25);
            this.lblPositionApplied.TabIndex = 3;
            this.lblPositionApplied.Text = "Position Applied:";
            // 
            // txtPositionApplied
            // 
            this.txtPositionApplied.Location = new System.Drawing.Point(519, 231);
            this.txtPositionApplied.Name = "txtPositionApplied";
            this.txtPositionApplied.Size = new System.Drawing.Size(333, 26);
            this.txtPositionApplied.TabIndex = 4;
            // 
            // lblInterviewDate
            // 
            this.lblInterviewDate.AutoSize = true;
            this.lblInterviewDate.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviewDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewDate.Location = new System.Drawing.Point(955, 203);
            this.lblInterviewDate.Name = "lblInterviewDate";
            this.lblInterviewDate.Size = new System.Drawing.Size(143, 25);
            this.lblInterviewDate.TabIndex = 5;
            this.lblInterviewDate.Text = "Interview Date:";
            this.lblInterviewDate.Click += new System.EventHandler(this.lblInterviewDate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(958, 231);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 6;
            // 
            // lblInterviewTime
            // 
            this.lblInterviewTime.AutoSize = true;
            this.lblInterviewTime.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviewTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewTime.Location = new System.Drawing.Point(44, 310);
            this.lblInterviewTime.Name = "lblInterviewTime";
            this.lblInterviewTime.Size = new System.Drawing.Size(145, 25);
            this.lblInterviewTime.TabIndex = 7;
            this.lblInterviewTime.Text = "Interview Time:";
            this.lblInterviewTime.Click += new System.EventHandler(this.lblInterviewTime_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(49, 338);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(200, 26);
            this.dtpTime.TabIndex = 8;
            // 
            // lblInterviewType
            // 
            this.lblInterviewType.AutoSize = true;
            this.lblInterviewType.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviewType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewType.Location = new System.Drawing.Point(282, 312);
            this.lblInterviewType.Name = "lblInterviewType";
            this.lblInterviewType.Size = new System.Drawing.Size(144, 25);
            this.lblInterviewType.TabIndex = 9;
            this.lblInterviewType.Text = "Interview Type:";
            this.lblInterviewType.Click += new System.EventHandler(this.lblInterviewType_Click);
            // 
            // cmbType
            // 
            this.cmbType.AccessibleName = "";
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Online",
            "Onsite"});
            this.cmbType.Location = new System.Drawing.Point(284, 340);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 10;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLocationLink
            // 
            this.lblLocationLink.AutoSize = true;
            this.lblLocationLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationLink.Location = new System.Drawing.Point(526, 310);
            this.lblLocationLink.Name = "lblLocationLink";
            this.lblLocationLink.Size = new System.Drawing.Size(220, 25);
            this.lblLocationLink.TabIndex = 11;
            this.lblLocationLink.Text = "Location / Meeting Link:";
            // 
            // txtLocationLink
            // 
            this.txtLocationLink.Location = new System.Drawing.Point(531, 338);
            this.txtLocationLink.Name = "txtLocationLink";
            this.txtLocationLink.Size = new System.Drawing.Size(333, 26);
            this.txtLocationLink.TabIndex = 12;
            // 
            // lblInterviewer
            // 
            this.lblInterviewer.AutoSize = true;
            this.lblInterviewer.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviewer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewer.Location = new System.Drawing.Point(909, 310);
            this.lblInterviewer.Name = "lblInterviewer";
            this.lblInterviewer.Size = new System.Drawing.Size(116, 25);
            this.lblInterviewer.TabIndex = 13;
            this.lblInterviewer.Text = "Interviewer:";
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(915, 338);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.Size = new System.Drawing.Size(333, 26);
            this.txtInterviewer.TabIndex = 14;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(45, 444);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(103, 25);
            this.lblRemarks.TabIndex = 15;
            this.lblRemarks.Text = "REMARKS:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 472);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(652, 96);
            this.textBox1.TabIndex = 16;
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveSchedule.Location = new System.Drawing.Point(889, 530);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(136, 38);
            this.btnSaveSchedule.TabIndex = 17;
            this.btnSaveSchedule.Text = "Save Schedule";
            this.btnSaveSchedule.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(1091, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(1364, 625);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtInterviewer);
            this.Controls.Add(this.lblInterviewer);
            this.Controls.Add(this.txtLocationLink);
            this.Controls.Add(this.lblLocationLink);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblInterviewType);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblInterviewTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblInterviewDate);
            this.Controls.Add(this.txtPositionApplied);
            this.Controls.Add(this.lblPositionApplied);
            this.Controls.Add(this.txtApplicantName);
            this.Controls.Add(this.lblApplicantName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Schedule";
            this.Text = "Ws";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.Label lblPositionApplied;
        private System.Windows.Forms.TextBox txtPositionApplied;
        private System.Windows.Forms.Label lblInterviewDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblInterviewTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblInterviewType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblLocationLink;
        private System.Windows.Forms.TextBox txtLocationLink;
        private System.Windows.Forms.Label lblInterviewer;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveSchedule;
        private System.Windows.Forms.Button btnCancel;
    }
}

