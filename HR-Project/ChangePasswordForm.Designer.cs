namespace HR_Project
{
    partial class ChangePasswordForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.picBoxShow = new System.Windows.Forms.PictureBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.picBoxShow1 = new System.Windows.Forms.PictureBox();
            this.llbConfirmPassword = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.picBoxShow2 = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 22, 34);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 52;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitle);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change Password";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 20, 24, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Controls.Add(this.lblCurrentPassword);
            this.pnlBody.Controls.Add(this.txtBoxCurrentPassword);
            this.pnlBody.Controls.Add(this.picBoxShow);
            this.pnlBody.Controls.Add(this.lblNewPassword);
            this.pnlBody.Controls.Add(this.txtBoxNewPassword);
            this.pnlBody.Controls.Add(this.picBoxShow1);
            this.pnlBody.Controls.Add(this.llbConfirmPassword);
            this.pnlBody.Controls.Add(this.txtBoxConfirmPassword);
            this.pnlBody.Controls.Add(this.picBoxShow2);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCurrentPassword.Location = new System.Drawing.Point(24, 20);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(90, 13);
            this.lblCurrentPassword.TabIndex = 1;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // txtBoxCurrentPassword
            // 
            this.txtBoxCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.txtBoxCurrentPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtBoxCurrentPassword.Location = new System.Drawing.Point(24, 38);
            this.txtBoxCurrentPassword.Name = "txtBoxCurrentPassword";
            this.txtBoxCurrentPassword.Size = new System.Drawing.Size(210, 26);
            this.txtBoxCurrentPassword.TabIndex = 2;
            this.txtBoxCurrentPassword.UseSystemPasswordChar = true;
            this.txtBoxCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // picBoxShow
            // 
            this.picBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxShow.Location = new System.Drawing.Point(238, 40);
            this.picBoxShow.Name = "picBoxShow";
            this.picBoxShow.Size = new System.Drawing.Size(20, 20);
            this.picBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxShow.TabIndex = 17;
            this.picBoxShow.TabStop = false;
            this.picBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShow.Click += new System.EventHandler(this.picBoxShow_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblNewPassword.Location = new System.Drawing.Point(24, 78);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.txtBoxNewPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtBoxNewPassword.Location = new System.Drawing.Point(24, 96);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(210, 26);
            this.txtBoxNewPassword.TabIndex = 4;
            this.txtBoxNewPassword.UseSystemPasswordChar = true;
            this.txtBoxNewPassword.TextChanged += new System.EventHandler(this.txtBoxNewPassword_TextChanged);
            // 
            // picBoxShow1
            // 
            this.picBoxShow1.BackColor = System.Drawing.Color.Transparent;
            this.picBoxShow1.Location = new System.Drawing.Point(238, 98);
            this.picBoxShow1.Name = "picBoxShow1";
            this.picBoxShow1.Size = new System.Drawing.Size(20, 20);
            this.picBoxShow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxShow1.TabIndex = 18;
            this.picBoxShow1.TabStop = false;
            this.picBoxShow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShow1.Click += new System.EventHandler(this.picBoxShow1_Click);
            // 
            // llbConfirmPassword
            // 
            this.llbConfirmPassword.AutoSize = true;
            this.llbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.llbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.llbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.llbConfirmPassword.Location = new System.Drawing.Point(24, 136);
            this.llbConfirmPassword.Name = "llbConfirmPassword";
            this.llbConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.llbConfirmPassword.TabIndex = 5;
            this.llbConfirmPassword.Text = "Confirm Password";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.txtBoxConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(24, 154);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(210, 26);
            this.txtBoxConfirmPassword.TabIndex = 6;
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // picBoxShow2
            // 
            this.picBoxShow2.BackColor = System.Drawing.Color.Transparent;
            this.picBoxShow2.Location = new System.Drawing.Point(238, 156);
            this.picBoxShow2.Name = "picBoxShow2";
            this.picBoxShow2.Size = new System.Drawing.Size(20, 20);
            this.picBoxShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxShow2.TabIndex = 19;
            this.picBoxShow2.TabStop = false;
            this.picBoxShow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShow2.Click += new System.EventHandler(this.picBoxShow2_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 56;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Controls.Add(this.btnChangePassword);
            this.pnlFooter.Controls.Add(this.btnCancel);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(10, 132, 255);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Location = new System.Drawing.Point(108, 14);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(120, 28);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 230);
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(238, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(320, 310);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtBoxCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Label llbConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBoxShow;
        private System.Windows.Forms.PictureBox picBoxShow1;
        private System.Windows.Forms.PictureBox picBoxShow2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
