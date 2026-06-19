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
using HR_Project.HR_System;

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
            this.MaximizeBox = false;

            txtBoxLoginPassword.UseSystemPasswordChar = true;
            picLoginShowPassword.Image = Properties.Resources.eye;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UITheme.StyleForm(this);

            UITheme.StyleTextBox(txtBoxLoginEmail);
            UITheme.StyleTextBox(txtBoxLoginPassword);

            UITheme.StylePrimaryButton(btnLogin);
            UITheme.StyleHeaderButton(btnLoginClose);

            txtBoxLoginPassword.UseSystemPasswordChar = true;
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string applicantQuery =
                    @"SELECT id, first_name
                    FROM applicants
                    WHERE email=@email
                    AND password=@password";

                    MySqlCommand applicantCmd =
                        new MySqlCommand(applicantQuery, conn);

                    applicantCmd.Parameters.AddWithValue(
                        "@email",
                        txtBoxLoginEmail.Text.Trim());

                    applicantCmd.Parameters.AddWithValue(
                        "@password",
                        txtBoxLoginPassword.Text);

                    MySqlDataReader reader =
                        applicantCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int applicantId =
                            Convert.ToInt32(reader["id"]);

                        string firstName =
                            reader["first_name"].ToString();

                        reader.Close();

                        Dashboard dash =
                            new Dashboard();

                        dash.ApplicantId =
                            applicantId;

                        dash.ApplicantName =
                            firstName;

                        dash.Show();

                        this.Hide();

                        return;
                    }

                    reader.Close();

                    string hrQuery =
                    @"SELECT
                          u.user_id,
                          u.first_name,
                          u.last_name,
                          r.role_name
                      FROM users u
                      INNER JOIN roles r
                          ON u.role_id = r.role_id
                      WHERE u.email = @email
                      AND u.password = @password
                      AND u.account_status = 'Active'";

                    MySqlCommand hrCmd =
                        new MySqlCommand(hrQuery, conn);

                    hrCmd.Parameters.AddWithValue(
                        "@email",
                        txtBoxLoginEmail.Text.Trim());

                    hrCmd.Parameters.AddWithValue(
                        "@password",
                        txtBoxLoginPassword.Text);

                    MySqlDataReader hrReader =
                        hrCmd.ExecuteReader();

                    if (hrReader.Read())
                    {
                        string role =
                            hrReader["role_name"].ToString();

                        string fullName =
                            hrReader["first_name"].ToString() + " " +
                            hrReader["last_name"].ToString();

                        hrReader.Close();

                        HRDashboard hrDashboard =
                            new HRDashboard();

                        hrDashboard.UserRole =
                            role;

                        hrDashboard.UserName =
                            fullName;

                        hrDashboard.Show();

                        this.Hide();

                        return;
                    }

                    hrReader.Close();

                    MessageBox.Show(
                        "Invalid Email or Password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        } 

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
