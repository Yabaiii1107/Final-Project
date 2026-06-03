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
using System.Text.RegularExpressions;

namespace HR_Project
{
    public partial class ApplicantRegistrationForm : Form
    {
        private bool passwordVisible1 = false;
        private bool passwordVisible2 = false;

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public ApplicantRegistrationForm()
        {
            InitializeComponent();

            this.Text = "Applicant Registration";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            btnRegister.BackColor = Color.RoyalBlue;
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            txtBoxPassword.UseSystemPasswordChar = true;
            picShowPassword.Image = Properties.Resources.eye;


            txtBoxConfirmPassword.UseSystemPasswordChar = true;
            picShowConfirmPassword.Image = Properties.Resources.eye;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            errorProviderRegistrationForm.Clear();

            // First Name
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                errorProviderRegistrationForm.SetError(txtBoxFirstName, "First name is required.");
                isValid = false;
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                errorProviderRegistrationForm.SetError(txtBoxLastName, "Last name is required.");
                isValid = false;
            }

            // Middle Name
            if (string.IsNullOrWhiteSpace(txtBoxMiddleName.Text))
            {
                errorProviderRegistrationForm.SetError(txtBoxMiddleName, "Middle Name is required.");
                isValid = false;
            }

            // Email
            if (!Regex.IsMatch(txtBoxEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProviderRegistrationForm.SetError(txtBoxEmail, "Invalid email address.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                errorProviderRegistrationForm.SetError(txtBoxEmail, "Email Address is required.");
                isValid = false;
            }

            // Contact Number
            if (!Regex.IsMatch(txtBoxContact.Text, @"^09\d{9}$"))
            {
                errorProviderRegistrationForm.SetError(txtBoxContact,
                    "Enter a valid 11-digit PH mobile number.");
                isValid = false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                errorProviderRegistrationForm.SetError(
                    txtBoxPassword,
                    "Password is required."
                );
                isValid = false;
            }
            else if (txtBoxPassword.Text.Length < 8)
            {
                errorProviderRegistrationForm.SetError(
                    txtBoxPassword,
                    "Minimum 8 characters."
                );
                isValid = false;
            }
            else if (!Regex.IsMatch(txtBoxPassword.Text,
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
            {
                errorProviderRegistrationForm.SetError(
                    txtBoxPassword,
                    "Must contain uppercase, lowercase and number."
                );
                isValid = false;
            }

            // Confirm Password
            if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                errorProviderRegistrationForm.SetError(txtBoxConfirmPassword,
                    "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            passwordVisible1 = !passwordVisible1;

            txtBoxPassword.UseSystemPasswordChar = !passwordVisible1;

            if (passwordVisible1)
            {
                picShowPassword.Image = Properties.Resources.eye_slash;
            }
            else
            {
                picShowPassword.Image = Properties.Resources.eye;
            }
        }

        private void picShowConfirmPassword_Click(object sender, EventArgs e)
        {
            passwordVisible2 = !passwordVisible2;

            txtBoxConfirmPassword.UseSystemPasswordChar = !passwordVisible2;

            if (passwordVisible2)
            {
                picShowConfirmPassword.Image = Properties.Resources.eye_slash;
            }
            else
            {
                picShowConfirmPassword.Image = Properties.Resources.eye;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Clear previous errors
                    errorProviderRegistrationForm.SetError(txtBoxEmail, "");
                    errorProviderRegistrationForm.SetError(txtBoxContact, "");

                    // Check duplicate email
                    string emailCheckQuery =
                        "SELECT COUNT(*) FROM applicants WHERE email = @em";

                    MySqlCommand emailCheckCmd =
                        new MySqlCommand(emailCheckQuery, conn);

                    emailCheckCmd.Parameters.AddWithValue(
                        "@em",
                        txtBoxEmail.Text.Trim()
                    );

                    if (Convert.ToInt32(emailCheckCmd.ExecuteScalar()) > 0)
                    {
                        errorProviderRegistrationForm.SetError(
                            txtBoxEmail,
                            "Email already registered."
                        );
                        return;
                    }

                    // Check duplicate contact
                    string contactCheckQuery =
                        "SELECT COUNT(*) FROM applicants WHERE contact = @ct";

                    MySqlCommand contactCheckCmd =
                        new MySqlCommand(contactCheckQuery, conn);

                    contactCheckCmd.Parameters.AddWithValue(
                        "@ct",
                        txtBoxContact.Text.Trim()
                    );

                    if (Convert.ToInt32(contactCheckCmd.ExecuteScalar()) > 0)
                    {
                        errorProviderRegistrationForm.SetError(
                            txtBoxContact,
                            "Contact number already registered."
                        );
                        return;
                    }

                    // INSERT
                    string query = @"INSERT INTO applicants
                            (first_name, last_name, middle_name,
                             email, contact, password)
                            VALUES
                            (@fn, @ln, @mn, @em, @ct, @pw)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@fn", txtBoxFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ln", txtBoxLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@mn", txtBoxMiddleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@em", txtBoxEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@ct", txtBoxContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@pw", txtBoxPassword.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrationClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
