using System;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApplicantLogin = new System.Windows.Forms.Label();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chckbxLoginRememberMe = new System.Windows.Forms.CheckBox();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lnklblRegister = new System.Windows.Forms.LinkLabel();
            this.picLoginShowPassword = new System.Windows.Forms.PictureBox();
            this.btnLoginClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplicantLogin
            // 
            this.lblApplicantLogin.AutoSize = true;
            this.lblApplicantLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblApplicantLogin.Location = new System.Drawing.Point(123, 52);
            this.lblApplicantLogin.Name = "lblApplicantLogin";
            this.lblApplicantLogin.Size = new System.Drawing.Size(161, 26);
            this.lblApplicantLogin.TabIndex = 0;
            this.lblApplicantLogin.Text = "Applicant Login";
            this.lblApplicantLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLoginEmail.Location = new System.Drawing.Point(154, 89);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(86, 15);
            this.lblLoginEmail.TabIndex = 1;
            this.lblLoginEmail.Text = "Email Address";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLoginPassword.Location = new System.Drawing.Point(165, 143);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(61, 15);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "Password";
            // 
            // txtBoxLoginEmail
            // 
            this.txtBoxLoginEmail.Location = new System.Drawing.Point(46, 107);
            this.txtBoxLoginEmail.Name = "txtBoxLoginEmail";
            this.txtBoxLoginEmail.Size = new System.Drawing.Size(315, 20);
            this.txtBoxLoginEmail.TabIndex = 3;
            // 
            // txtBoxLoginPassword
            // 
            this.txtBoxLoginPassword.Location = new System.Drawing.Point(46, 161);
            this.txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            this.txtBoxLoginPassword.Size = new System.Drawing.Size(315, 20);
            this.txtBoxLoginPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.Location = new System.Drawing.Point(44, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chckbxLoginRememberMe
            // 
            this.chckbxLoginRememberMe.AutoSize = true;
            this.chckbxLoginRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.chckbxLoginRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chckbxLoginRememberMe.Location = new System.Drawing.Point(46, 187);
            this.chckbxLoginRememberMe.Name = "chckbxLoginRememberMe";
            this.chckbxLoginRememberMe.Size = new System.Drawing.Size(110, 19);
            this.chckbxLoginRememberMe.TabIndex = 7;
            this.chckbxLoginRememberMe.Text = "Remember me";
            this.chckbxLoginRememberMe.UseVisualStyleBackColor = false;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNoAccount.Location = new System.Drawing.Point(43, 249);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(153, 15);
            this.lblNoAccount.TabIndex = 8;
            this.lblNoAccount.Text = "Don\'t have an account yet?";
            this.lblNoAccount.Click += new System.EventHandler(this.lblNoAccount_Click);
            // 
            // lnklblRegister
            // 
            this.lnklblRegister.AutoSize = true;
            this.lnklblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lnklblRegister.Location = new System.Drawing.Point(194, 251);
            this.lnklblRegister.Name = "lnklblRegister";
            this.lnklblRegister.Size = new System.Drawing.Size(46, 13);
            this.lnklblRegister.TabIndex = 9;
            this.lnklblRegister.TabStop = true;
            this.lnklblRegister.Text = "Register";
            this.lnklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRegister_LinkClicked);
            // 
            // picLoginShowPassword
            // 
            this.picLoginShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.picLoginShowPassword.Location = new System.Drawing.Point(367, 161);
            this.picLoginShowPassword.Name = "picLoginShowPassword";
            this.picLoginShowPassword.Size = new System.Drawing.Size(18, 20);
            this.picLoginShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginShowPassword.TabIndex = 10;
            this.picLoginShowPassword.TabStop = false;
            this.picLoginShowPassword.Click += new System.EventHandler(this.picLoginShowPassword_Click);
            // 
            // btnLoginClose
            // 
            this.btnLoginClose.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginClose.FlatAppearance.BorderSize = 0;
            this.btnLoginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginClose.ForeColor = System.Drawing.Color.Red;
            this.btnLoginClose.Location = new System.Drawing.Point(384, 13);
            this.btnLoginClose.Name = "btnLoginClose";
            this.btnLoginClose.Size = new System.Drawing.Size(24, 23);
            this.btnLoginClose.TabIndex = 11;
            this.btnLoginClose.Text = "X";
            this.btnLoginClose.UseVisualStyleBackColor = false;
            this.btnLoginClose.Click += new System.EventHandler(this.btnLoginClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(420, 329);
            this.Controls.Add(this.btnLoginClose);
            this.Controls.Add(this.picLoginShowPassword);
            this.Controls.Add(this.lnklblRegister);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.chckbxLoginRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxLoginPassword);
            this.Controls.Add(this.txtBoxLoginEmail);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.lblApplicantLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicantLogin;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtBoxLoginEmail;
        private System.Windows.Forms.TextBox txtBoxLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chckbxLoginRememberMe;
        private Label lblNoAccount;
        private LinkLabel lnklblRegister;
        private PictureBox picLoginShowPassword;
        private Button btnLoginClose;
    }
}
