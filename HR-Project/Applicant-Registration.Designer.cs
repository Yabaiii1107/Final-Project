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
            this.lblApplicantRegistration = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblPersonalInformation = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblContactInformation = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.lblAccountInformation = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblHaveaAccount = new System.Windows.Forms.Label();
            this.linklblLogin = new System.Windows.Forms.LinkLabel();
            this.picShowConfirmPassword = new System.Windows.Forms.PictureBox();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            this.errorProviderRegistrationForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picShowConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistrationForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplicantRegistration
            // 
            this.lblApplicantRegistration.AutoSize = true;
            this.lblApplicantRegistration.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantRegistration.Location = new System.Drawing.Point(282, 37);
            this.lblApplicantRegistration.Name = "lblApplicantRegistration";
            this.lblApplicantRegistration.Size = new System.Drawing.Size(187, 15);
            this.lblApplicantRegistration.TabIndex = 0;
            this.lblApplicantRegistration.Text = "APPLICANT REGISTRATION";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(-70, 52);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(925, 26);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________\r\n\r\n";
            // 
            // lblPersonalInformation
            // 
            this.lblPersonalInformation.AutoSize = true;
            this.lblPersonalInformation.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInformation.Location = new System.Drawing.Point(13, 82);
            this.lblPersonalInformation.Name = "lblPersonalInformation";
            this.lblPersonalInformation.Size = new System.Drawing.Size(153, 15);
            this.lblPersonalInformation.TabIndex = 2;
            this.lblPersonalInformation.Text = "Personal Information:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 107);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(84, 105);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFirstName.TabIndex = 4;
            this.txtBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFirstName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(234, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(308, 109);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLastName.TabIndex = 6;
            this.txtBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLastName_KeyPress);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(442, 111);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(85, 16);
            this.lblMiddleName.TabIndex = 7;
            this.lblMiddleName.Text = "Middle Name:";
            this.lblMiddleName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(533, 109);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMiddleName.TabIndex = 8;
            this.txtBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMiddleName_KeyPress);
            // 
            // lblContactInformation
            // 
            this.lblContactInformation.AutoSize = true;
            this.lblContactInformation.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInformation.Location = new System.Drawing.Point(13, 158);
            this.lblContactInformation.Name = "lblContactInformation";
            this.lblContactInformation.Size = new System.Drawing.Size(147, 15);
            this.lblContactInformation.TabIndex = 9;
            this.lblContactInformation.Text = "Contact Information:";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Location = new System.Drawing.Point(-46, 132);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(925, 26);
            this.lblLine1.TabIndex = 10;
            this.lblLine1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________\r\n\r\n";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(102, 184);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(173, 20);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(305, 188);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(103, 16);
            this.lblContact.TabIndex = 14;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Location = new System.Drawing.Point(414, 186);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(100, 20);
            this.txtBoxContact.TabIndex = 15;
            this.txtBoxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxContact_KeyPress);
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInformation.Location = new System.Drawing.Point(12, 235);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(148, 15);
            this.lblAccountInformation.TabIndex = 16;
            this.lblAccountInformation.Text = "Account Information:";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.BackColor = System.Drawing.SystemColors.Control;
            this.lblLine2.Location = new System.Drawing.Point(-70, 209);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(925, 26);
            this.lblLine2.TabIndex = 17;
            this.lblLine2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________\r\n\r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 16);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(81, 259);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 19;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(234, 263);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(106, 16);
            this.lblConfirmPassword.TabIndex = 20;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(346, 259);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxConfirmPassword.TabIndex = 21;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(632, 287);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 40);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblHaveaAccount
            // 
            this.lblHaveaAccount.AutoSize = true;
            this.lblHaveaAccount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveaAccount.Location = new System.Drawing.Point(586, 330);
            this.lblHaveaAccount.Name = "lblHaveaAccount";
            this.lblHaveaAccount.Size = new System.Drawing.Size(157, 16);
            this.lblHaveaAccount.TabIndex = 23;
            this.lblHaveaAccount.Text = "Already have an account?";
            // 
            // linklblLogin
            // 
            this.linklblLogin.AutoSize = true;
            this.linklblLogin.Location = new System.Drawing.Point(739, 331);
            this.linklblLogin.Name = "linklblLogin";
            this.linklblLogin.Size = new System.Drawing.Size(33, 13);
            this.linklblLogin.TabIndex = 24;
            this.linklblLogin.TabStop = true;
            this.linklblLogin.Text = "Login";
            this.linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // picShowConfirmPassword
            // 
            this.picShowConfirmPassword.Location = new System.Drawing.Point(453, 261);
            this.picShowConfirmPassword.Name = "picShowConfirmPassword";
            this.picShowConfirmPassword.Size = new System.Drawing.Size(16, 17);
            this.picShowConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowConfirmPassword.TabIndex = 26;
            this.picShowConfirmPassword.TabStop = false;
            this.picShowConfirmPassword.Click += new System.EventHandler(this.picShowConfirmPassword_Click);
            // 
            // picShowPassword
            // 
            this.picShowPassword.Location = new System.Drawing.Point(188, 259);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(16, 17);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPassword.TabIndex = 25;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Click += new System.EventHandler(this.picShowPassword_Click);
            // 
            // errorProviderRegistrationForm
            // 
            this.errorProviderRegistrationForm.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // ApplicantRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.picShowConfirmPassword);
            this.Controls.Add(this.picShowPassword);
            this.Controls.Add(this.linklblLogin);
            this.Controls.Add(this.lblHaveaAccount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblAccountInformation);
            this.Controls.Add(this.txtBoxContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.lblContactInformation);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPersonalInformation);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblApplicantRegistration);
            this.Name = "ApplicantRegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistrationForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicantRegistration;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblPersonalInformation;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.Label lblContactInformation;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.Label lblAccountInformation;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblHaveaAccount;
        private System.Windows.Forms.LinkLabel linklblLogin;
        private System.Windows.Forms.PictureBox picShowPassword;
        private System.Windows.Forms.PictureBox picShowConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProviderRegistrationForm;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
    }
}

