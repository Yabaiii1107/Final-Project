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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.Employmenttype = new System.Windows.Forms.Label();
            this.cmbEmploymentType = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkCurrentWork = new System.Windows.Forms.CheckBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtJobDiscription = new System.Windows.Forms.Label();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(151, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Work Experience";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Location = new System.Drawing.Point(52, 57);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(55, 73);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(123, 20);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.Text = "  ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Location = new System.Drawing.Point(52, 106);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(95, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position / Job Title";
            // 
            // Employmenttype
            // 
            this.Employmenttype.AutoSize = true;
            this.Employmenttype.BackColor = System.Drawing.Color.Transparent;
            this.Employmenttype.Location = new System.Drawing.Point(52, 156);
            this.Employmenttype.Name = "Employmenttype";
            this.Employmenttype.Size = new System.Drawing.Size(91, 13);
            this.Employmenttype.TabIndex = 4;
            this.Employmenttype.Text = "Employment Type";
            // 
            // cmbEmploymentType
            // 
            this.cmbEmploymentType.FormattingEnabled = true;
            this.cmbEmploymentType.Items.AddRange(new object[] {
            "Full-time",
            "Part-time",
            "Contract",
            "Internship",
            "Freelance"});
            this.cmbEmploymentType.Location = new System.Drawing.Point(55, 172);
            this.cmbEmploymentType.Name = "cmbEmploymentType";
            this.cmbEmploymentType.Size = new System.Drawing.Size(121, 21);
            this.cmbEmploymentType.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Location = new System.Drawing.Point(52, 212);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(55, 13);
            this.txtDate.TabIndex = 6;
            this.txtDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(55, 228);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // txtEndDate
            // 
            this.txtEndDate.AutoSize = true;
            this.txtEndDate.BackColor = System.Drawing.Color.Transparent;
            this.txtEndDate.Location = new System.Drawing.Point(255, 212);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(52, 13);
            this.txtEndDate.TabIndex = 8;
            this.txtEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(258, 228);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(121, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // chkCurrentWork
            // 
            this.chkCurrentWork.AutoSize = true;
            this.chkCurrentWork.BackColor = System.Drawing.Color.Transparent;
            this.chkCurrentWork.Location = new System.Drawing.Point(55, 254);
            this.chkCurrentWork.Name = "chkCurrentWork";
            this.chkCurrentWork.Size = new System.Drawing.Size(122, 17);
            this.chkCurrentWork.TabIndex = 10;
            this.chkCurrentWork.Text = "I currently work here";
            this.chkCurrentWork.UseVisualStyleBackColor = false;
            this.chkCurrentWork.CheckedChanged += new System.EventHandler(this.chkCurrentWork_CheckedChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(55, 122);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(123, 20);
            this.txtPosition.TabIndex = 11;
            // 
            // txtJobDiscription
            // 
            this.txtJobDiscription.AutoSize = true;
            this.txtJobDiscription.BackColor = System.Drawing.Color.Transparent;
            this.txtJobDiscription.Location = new System.Drawing.Point(54, 284);
            this.txtJobDiscription.Name = "txtJobDiscription";
            this.txtJobDiscription.Size = new System.Drawing.Size(80, 13);
            this.txtJobDiscription.TabIndex = 12;
            this.txtJobDiscription.Text = "Job Description";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.Location = new System.Drawing.Point(55, 300);
            this.txtJobDescription.Multiline = true;
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Size = new System.Drawing.Size(145, 22);
            this.txtJobDescription.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 27);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(421, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 27);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WorkExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.txtJobDiscription);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.chkCurrentWork);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cmbEmploymentType);
            this.Controls.Add(this.Employmenttype);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkExperience";
            this.Text = "WorkExperience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
