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
            this.txtCompanyName = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.Label();
            this.Employmenttype = new System.Windows.Forms.Label();
            this.cboEmploymentType = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.Label();
            this.dptEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkCurrentWork = new System.Windows.Forms.CheckBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtJobDiscription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnWorkExperienceClose = new System.Windows.Forms.Button();
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
            // txtCompanyName
            // 
            this.txtCompanyName.AutoSize = true;
            this.txtCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.txtCompanyName.Location = new System.Drawing.Point(52, 57);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(82, 13);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.Text = "Company Name";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(55, 73);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(123, 20);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.Text = "  ";
            // 
            // txtPosition
            // 
            this.txtPosition.AutoSize = true;
            this.txtPosition.BackColor = System.Drawing.Color.Transparent;
            this.txtPosition.Location = new System.Drawing.Point(52, 106);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(95, 13);
            this.txtPosition.TabIndex = 3;
            this.txtPosition.Text = "Position / Job Title";
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
            // cboEmploymentType
            // 
            this.cboEmploymentType.FormattingEnabled = true;
            this.cboEmploymentType.Location = new System.Drawing.Point(55, 172);
            this.cboEmploymentType.Name = "cboEmploymentType";
            this.cboEmploymentType.Size = new System.Drawing.Size(121, 21);
            this.cboEmploymentType.TabIndex = 5;
            this.cboEmploymentType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // dptEndDate
            // 
            this.dptEndDate.Location = new System.Drawing.Point(258, 228);
            this.dptEndDate.Name = "dptEndDate";
            this.dptEndDate.Size = new System.Drawing.Size(121, 20);
            this.dptEndDate.TabIndex = 9;
            this.dptEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(55, 122);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(123, 20);
            this.txtJobTitle.TabIndex = 11;
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(55, 300);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(145, 22);
            this.txtDescription.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 27);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(421, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 27);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnWorkExperienceClose
            // 
            this.btnWorkExperienceClose.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkExperienceClose.FlatAppearance.BorderSize = 0;
            this.btnWorkExperienceClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkExperienceClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkExperienceClose.ForeColor = System.Drawing.Color.Red;
            this.btnWorkExperienceClose.Location = new System.Drawing.Point(468, -1);
            this.btnWorkExperienceClose.Name = "btnWorkExperienceClose";
            this.btnWorkExperienceClose.Size = new System.Drawing.Size(36, 29);
            this.btnWorkExperienceClose.TabIndex = 16;
            this.btnWorkExperienceClose.Text = "X";
            this.btnWorkExperienceClose.UseVisualStyleBackColor = false;
            this.btnWorkExperienceClose.Click += new System.EventHandler(this.btnDashboardClose_Click);
            // 
            // WorkExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.btnWorkExperienceClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtJobDiscription);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.chkCurrentWork);
            this.Controls.Add(this.dptEndDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cboEmploymentType);
            this.Controls.Add(this.Employmenttype);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkExperience";
            this.Text = "WorkExperience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label txtCompanyName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label txtPosition;
        private System.Windows.Forms.Label Employmenttype;
        private System.Windows.Forms.ComboBox cboEmploymentType;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label txtEndDate;
        private System.Windows.Forms.DateTimePicker dptEndDate;
        private System.Windows.Forms.CheckBox chkCurrentWork;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label txtJobDiscription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnWorkExperienceClose;
    }
}