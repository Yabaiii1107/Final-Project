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

            ApplicantRegistrationForm registerForm = new ApplicantRegistrationForm();

            registerForm.FormClosed += (s, args) => this.Show();

            registerForm.Show();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT first_name
                             FROM applicants
                             WHERE email=@email
                             AND password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@email", txtBoxLoginEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtBoxLoginPassword.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Dashboard dash = new Dashboard();

                        dash.ApplicantName = reader["first_name"].ToString();

                        dash.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
