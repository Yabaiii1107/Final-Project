namespace HR_Project
{
    partial class WorkExperience
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.Employmenttype = new System.Windows.Forms.Label();
            this.cmbEmploymentType = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkCurrentWork = new System.Windows.Forms.CheckBox();
            this.txtJobDiscription = new System.Windows.Forms.Label();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 52);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Work Experience";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlBody.Controls.Add(this.lblCompanyName);
            this.pnlBody.Controls.Add(this.txtCompanyName);
            this.pnlBody.Controls.Add(this.lblPosition);
            this.pnlBody.Controls.Add(this.txtPosition);
            this.pnlBody.Controls.Add(this.Employmenttype);
            this.pnlBody.Controls.Add(this.cmbEmploymentType);
            this.pnlBody.Controls.Add(this.txtDate);
            this.pnlBody.Controls.Add(this.dtpStartDate);
            this.pnlBody.Controls.Add(this.txtEndDate);
            this.pnlBody.Controls.Add(this.dtpEndDate);
            this.pnlBody.Controls.Add(this.chkCurrentWork);
            this.pnlBody.Controls.Add(this.txtJobDiscription);
            this.pnlBody.Controls.Add(this.txtJobDescription);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 52);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 20, 24, 0);
            this.pnlBody.Size = new System.Drawing.Size(480, 377);
            this.pnlBody.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCompanyName.Location = new System.Drawing.Point(24, 20);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(94, 15);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCompanyName.Location = new System.Drawing.Point(24, 38);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(210, 23);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPosition.Location = new System.Drawing.Point(24, 76);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(109, 15);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position / Job Title";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPosition.Location = new System.Drawing.Point(24, 94);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(210, 23);
            this.txtPosition.TabIndex = 1;
            // 
            // Employmenttype
            // 
            this.Employmenttype.AutoSize = true;
            this.Employmenttype.BackColor = System.Drawing.Color.Transparent;
            this.Employmenttype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Employmenttype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Employmenttype.Location = new System.Drawing.Point(24, 132);
            this.Employmenttype.Name = "Employmenttype";
            this.Employmenttype.Size = new System.Drawing.Size(106, 15);
            this.Employmenttype.TabIndex = 2;
            this.Employmenttype.Text = "Employment Type";
            // 
            // cmbEmploymentType
            // 
            this.cmbEmploymentType.BackColor = System.Drawing.Color.White;
            this.cmbEmploymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmploymentType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEmploymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbEmploymentType.FormattingEnabled = true;
            this.cmbEmploymentType.Items.AddRange(new object[] {
            "Full-time",
            "Part-time",
            "Contract",
            "Internship",
            "Freelance"});
            this.cmbEmploymentType.Location = new System.Drawing.Point(24, 150);
            this.cmbEmploymentType.Name = "cmbEmploymentType";
            this.cmbEmploymentType.Size = new System.Drawing.Size(210, 23);
            this.cmbEmploymentType.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDate.Location = new System.Drawing.Point(24, 188);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(65, 15);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Location = new System.Drawing.Point(24, 206);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(190, 23);
            this.dtpStartDate.TabIndex = 3;
            // 
            // txtEndDate
            // 
            this.txtEndDate.AutoSize = true;
            this.txtEndDate.BackColor = System.Drawing.Color.Transparent;
            this.txtEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEndDate.Location = new System.Drawing.Point(240, 188);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(57, 15);
            this.txtEndDate.TabIndex = 4;
            this.txtEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Location = new System.Drawing.Point(240, 206);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(190, 23);
            this.dtpEndDate.TabIndex = 4;
            // 
            // chkCurrentWork
            // 
            this.chkCurrentWork.AutoSize = true;
            this.chkCurrentWork.BackColor = System.Drawing.Color.Transparent;
            this.chkCurrentWork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCurrentWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkCurrentWork.Location = new System.Drawing.Point(24, 240);
            this.chkCurrentWork.Name = "chkCurrentWork";
            this.chkCurrentWork.Size = new System.Drawing.Size(134, 19);
            this.chkCurrentWork.TabIndex = 5;
            this.chkCurrentWork.Text = "I currently work here";
            this.chkCurrentWork.UseVisualStyleBackColor = false;
            this.chkCurrentWork.CheckedChanged += new System.EventHandler(this.chkCurrentWork_CheckedChanged);
            // 
            // txtJobDiscription
            // 
            this.txtJobDiscription.AutoSize = true;
            this.txtJobDiscription.BackColor = System.Drawing.Color.Transparent;
            this.txtJobDiscription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtJobDiscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtJobDiscription.Location = new System.Drawing.Point(24, 272);
            this.txtJobDiscription.Name = "txtJobDiscription";
            this.txtJobDiscription.Size = new System.Drawing.Size(93, 15);
            this.txtJobDiscription.TabIndex = 6;
            this.txtJobDiscription.Text = "Job Description";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.BackColor = System.Drawing.Color.White;
            this.txtJobDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJobDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtJobDescription.Location = new System.Drawing.Point(24, 290);
            this.txtJobDescription.Multiline = true;
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJobDescription.Size = new System.Drawing.Size(406, 72);
            this.txtJobDescription.TabIndex = 6;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 429);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(480, 56);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(303, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.Location = new System.Drawing.Point(385, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WorkExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(480, 485);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkExperience";
            this.Text = "WorkExperience";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label Employmenttype;
        private System.Windows.Forms.ComboBox cmbEmploymentType;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label txtEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chkCurrentWork;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label txtJobDiscription;
        private System.Windows.Forms.TextBox txtJobDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
