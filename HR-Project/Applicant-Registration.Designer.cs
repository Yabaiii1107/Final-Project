namespace HR_Project
{
    partial class ApplicantRegistrationForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblApplicantRegistration = new System.Windows.Forms.Label();
            this.btnRegistrationClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblPersonalInformation = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblContactInformation = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.lblAccountInformation = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.picShowConfirmPassword = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblHaveaAccount = new System.Windows.Forms.Label();
            this.linklblLogin = new System.Windows.Forms.LinkLabel();
            this.errorProviderRegistrationForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistrationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblApplicantRegistration);
            this.pnlHeader.Controls.Add(this.btnRegistrationClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 52);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblApplicantRegistration
            // 
            this.lblApplicantRegistration.AutoSize = true;
            this.lblApplicantRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantRegistration.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblApplicantRegistration.ForeColor = System.Drawing.Color.White;
            this.lblApplicantRegistration.Location = new System.Drawing.Point(20, 13);
            this.lblApplicantRegistration.Name = "lblApplicantRegistration";
            this.lblApplicantRegistration.Size = new System.Drawing.Size(203, 25);
            this.lblApplicantRegistration.TabIndex = 0;
            this.lblApplicantRegistration.Text = "Applicant Registration";
            // 
            // btnRegistrationClose
            // 
            this.btnRegistrationClose.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrationClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrationClose.FlatAppearance.BorderSize = 0;
            this.btnRegistrationClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnRegistrationClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrationClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRegistrationClose.Location = new System.Drawing.Point(754, 12);
            this.btnRegistrationClose.Name = "btnRegistrationClose";
            this.btnRegistrationClose.Size = new System.Drawing.Size(30, 28);
            this.btnRegistrationClose.TabIndex = 0;
            this.btnRegistrationClose.Text = "✕";
            this.btnRegistrationClose.UseVisualStyleBackColor = false;
            this.btnRegistrationClose.Click += new System.EventHandler(this.btnRegistrationClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlBody.Controls.Add(this.lblPersonalInformation);
            this.pnlBody.Controls.Add(this.lblFirstName);
            this.pnlBody.Controls.Add(this.txtBoxFirstName);
            this.pnlBody.Controls.Add(this.lblLastName);
            this.pnlBody.Controls.Add(this.txtBoxLastName);
            this.pnlBody.Controls.Add(this.lblMiddleName);
            this.pnlBody.Controls.Add(this.txtBoxMiddleName);
            this.pnlBody.Controls.Add(this.lblDOB);
            this.pnlBody.Controls.Add(this.dtpDOB);
            this.pnlBody.Controls.Add(this.lblContactInformation);
            this.pnlBody.Controls.Add(this.lblEmail);
            this.pnlBody.Controls.Add(this.txtBoxEmail);
            this.pnlBody.Controls.Add(this.lblContact);
            this.pnlBody.Controls.Add(this.txtBoxContact);
            this.pnlBody.Controls.Add(this.lblAccountInformation);
            this.pnlBody.Controls.Add(this.lblPassword);
            this.pnlBody.Controls.Add(this.txtBoxPassword);
            this.pnlBody.Controls.Add(this.picShowPassword);
            this.pnlBody.Controls.Add(this.lblConfirmPassword);
            this.pnlBody.Controls.Add(this.txtBoxConfirmPassword);
            this.pnlBody.Controls.Add(this.picShowConfirmPassword);
            this.pnlBody.Controls.Add(this.btnRegister);
            this.pnlBody.Controls.Add(this.lblHaveaAccount);
            this.pnlBody.Controls.Add(this.linklblLogin);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 52);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.pnlBody.Size = new System.Drawing.Size(784, 348);
            this.pnlBody.TabIndex = 0;
            // 
            // lblPersonalInformation
            // 
            this.lblPersonalInformation.AutoSize = true;
            this.lblPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPersonalInformation.Location = new System.Drawing.Point(24, 20);
            this.lblPersonalInformation.Name = "lblPersonalInformation";
            this.lblPersonalInformation.Size = new System.Drawing.Size(150, 19);
            this.lblPersonalInformation.TabIndex = 0;
            this.lblPersonalInformation.Text = "Personal Information";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblFirstName.Location = new System.Drawing.Point(24, 52);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.BackColor = System.Drawing.Color.White;
            this.txtBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxFirstName.Location = new System.Drawing.Point(24, 70);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(160, 23);
            this.txtBoxFirstName.TabIndex = 1;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            this.txtBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFirstName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblLastName.Location = new System.Drawing.Point(200, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.BackColor = System.Drawing.Color.White;
            this.txtBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxLastName.Location = new System.Drawing.Point(200, 70);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(160, 23);
            this.txtBoxLastName.TabIndex = 2;
            this.txtBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLastName_KeyPress);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblMiddleName.Location = new System.Drawing.Point(376, 52);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(79, 15);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.BackColor = System.Drawing.Color.White;
            this.txtBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxMiddleName.Location = new System.Drawing.Point(376, 70);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(160, 23);
            this.txtBoxMiddleName.TabIndex = 3;
            this.txtBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMiddleName_KeyPress);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblDOB.Location = new System.Drawing.Point(552, 52);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(73, 15);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(552, 70);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(152, 23);
            this.dtpDOB.TabIndex = 4;
            // 
            // lblContactInformation
            // 
            this.lblContactInformation.AutoSize = true;
            this.lblContactInformation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContactInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblContactInformation.Location = new System.Drawing.Point(24, 116);
            this.lblContactInformation.Name = "lblContactInformation";
            this.lblContactInformation.Size = new System.Drawing.Size(143, 19);
            this.lblContactInformation.TabIndex = 5;
            this.lblContactInformation.Text = "Contact Information";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblEmail.Location = new System.Drawing.Point(24, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.White;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxEmail.Location = new System.Drawing.Point(24, 166);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(260, 23);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblContact.Location = new System.Drawing.Point(300, 148);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(96, 15);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact Number";
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.BackColor = System.Drawing.Color.White;
            this.txtBoxContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxContact.Location = new System.Drawing.Point(300, 166);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(200, 23);
            this.txtBoxContact.TabIndex = 6;
            this.txtBoxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxContact_KeyPress);
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccountInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblAccountInformation.Location = new System.Drawing.Point(24, 212);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(146, 19);
            this.lblAccountInformation.TabIndex = 8;
            this.lblAccountInformation.Text = "Account Information";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblPassword.Location = new System.Drawing.Point(24, 244);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxPassword.Location = new System.Drawing.Point(24, 262);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(180, 23);
            this.txtBoxPassword.TabIndex = 7;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // picShowPassword
            // 
            this.picShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowPassword.Location = new System.Drawing.Point(208, 265);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(18, 18);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPassword.TabIndex = 10;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Click += new System.EventHandler(this.picShowPassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(240, 244);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(104, 15);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(240, 262);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(180, 23);
            this.txtBoxConfirmPassword.TabIndex = 8;
            // 
            // picShowConfirmPassword
            // 
            this.picShowConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowConfirmPassword.Location = new System.Drawing.Point(424, 265);
            this.picShowConfirmPassword.Name = "picShowConfirmPassword";
            this.picShowConfirmPassword.Size = new System.Drawing.Size(18, 18);
            this.picShowConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowConfirmPassword.TabIndex = 12;
            this.picShowConfirmPassword.TabStop = false;
            this.picShowConfirmPassword.Click += new System.EventHandler(this.picShowConfirmPassword_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(580, 255);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(148, 36);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblHaveaAccount
            // 
            this.lblHaveaAccount.AutoSize = true;
            this.lblHaveaAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHaveaAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblHaveaAccount.Location = new System.Drawing.Point(543, 302);
            this.lblHaveaAccount.Name = "lblHaveaAccount";
            this.lblHaveaAccount.Size = new System.Drawing.Size(142, 15);
            this.lblHaveaAccount.TabIndex = 13;
            this.lblHaveaAccount.Text = "Already have an account?";
            // 
            // linklblLogin
            // 
            this.linklblLogin.AutoSize = true;
            this.linklblLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linklblLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.linklblLogin.Location = new System.Drawing.Point(691, 302);
            this.linklblLogin.Name = "linklblLogin";
            this.linklblLogin.Size = new System.Drawing.Size(37, 15);
            this.linklblLogin.TabIndex = 14;
            this.linklblLogin.TabStop = true;
            this.linklblLogin.Text = "Login";
            this.linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // errorProviderRegistrationForm
            // 
            this.errorProviderRegistrationForm.ContainerControl = this;
            // 
            // ApplicantRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicantRegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistrationForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblApplicantRegistration;
        private System.Windows.Forms.Button btnRegistrationClose;
        private System.Windows.Forms.Label lblPersonalInformation;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblContactInformation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.Label lblAccountInformation;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.PictureBox picShowPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.PictureBox picShowConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblHaveaAccount;
        private System.Windows.Forms.LinkLabel linklblLogin;
        private System.Windows.Forms.ErrorProvider errorProviderRegistrationForm;
    }
}
