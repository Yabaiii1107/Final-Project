using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project
{
    public partial class Login : Form
    {
        private bool passwordVisible3 = false;
      
        public Login()
        {
            InitializeComponent();
            this.Text = "Applicant Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;

            txtBoxLoginPassword.UseSystemPasswordChar = true;
            picLoginShowPassword.Image = Properties.Resources.eye;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (ApplicantRegistrationForm registerForm = new ApplicantRegistrationForm())
            {
                registerForm.ShowDialog();
            }

            this.Show();
        }

        private void lblNoAccount_Click(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picLoginShowPassword_Click(object sender, EventArgs e)
        {
            passwordVisible3 = !passwordVisible3;

            txtBoxLoginPassword.UseSystemPasswordChar = !passwordVisible3;

            if (passwordVisible3)
            {
                picLoginShowPassword.Image = Properties.Resources.eye_slash;
            }
            else
            {
                picLoginShowPassword.Image = Properties.Resources.eye;
            }
        }
    }
}
