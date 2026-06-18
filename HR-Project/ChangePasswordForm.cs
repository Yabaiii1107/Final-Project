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
    public partial class ChangePasswordForm : Form
    {
        private bool passwordVisible1 = false;
        private bool passwordVisible2 = false;
        private bool passwordVisible3 = false;

        public int ApplicantId { get; set; }

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public ChangePasswordForm()
        {
            InitializeComponent();

            txtBoxCurrentPassword.UseSystemPasswordChar = true;
            picBoxShow.Image = Properties.Resources.eye;

            txtBoxNewPassword.UseSystemPasswordChar = true;
            picBoxShow1.Image = Properties.Resources.eye;

            txtBoxConfirmPassword.UseSystemPasswordChar = true;
            picBoxShow2.Image = Properties.Resources.eye;
        }


        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxCurrentPassword, "");
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string currentPass = txtBoxCurrentPassword.Text;
            string newPass = txtBoxNewPassword.Text;
            string confirmPass = txtBoxConfirmPassword.Text;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(currentPass))
            {
                errorProvider1.SetError(txtBoxCurrentPassword, "Current password is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(newPass))
            {
                errorProvider1.SetError(txtBoxNewPassword, "New password is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(confirmPass))
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "Confirm password is required.");
                isValid = false;
            }

            if (!isValid)
                return;

            if (newPass != confirmPass)
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "Passwords do not match.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
                SELECT password
                FROM applicants
                WHERE id = @id";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", ApplicantId);

                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                string dbPassword = result.ToString();

                if (dbPassword != currentPass)
                {
                    errorProvider1.SetError(txtBoxCurrentPassword, "Incorrect current password.");
                    return;
                }

                string updateQuery = @"
                UPDATE applicants
                SET password = @newPass
                WHERE id = @id";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@newPass", newPass);
                updateCmd.Parameters.AddWithValue("@id", ApplicantId);

                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Password changed successfully!");

            this.Close();
        }

        private void txtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxCurrentPassword, "");
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxCurrentPassword, "");
        }

        private void picBoxShow2_Click(object sender, EventArgs e)
        {
            passwordVisible3 = !passwordVisible3;

            txtBoxConfirmPassword.UseSystemPasswordChar = !passwordVisible3;

            if (passwordVisible3)
            {
                picBoxShow2.Image = Properties.Resources.eye_slash;
            }
            else
            {
                picBoxShow2.Image = Properties.Resources.eye;
            }
        }

        private void picBoxShow1_Click(object sender, EventArgs e)
        {
            passwordVisible2 = !passwordVisible2;

            txtBoxNewPassword.UseSystemPasswordChar = !passwordVisible2;

            if (passwordVisible2)
            {
                picBoxShow1.Image = Properties.Resources.eye_slash;
            }
            else
            {
                picBoxShow1.Image = Properties.Resources.eye;
            }
        }

        private void picBoxShow_Click(object sender, EventArgs e)
        {
            passwordVisible1 = !passwordVisible1;

            txtBoxCurrentPassword.UseSystemPasswordChar = !passwordVisible1;

            if (passwordVisible1)
            {
                picBoxShow.Image = Properties.Resources.eye_slash;
            }
            else
            {
                picBoxShow.Image = Properties.Resources.eye;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
