using System;
using System.IO;
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

    public partial class profilepage : Form
    {
        private bool editMode = false;

        private byte[] profileImageBytes = null;

        public int applicantId;

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public profilepage(int applicantId)
        {
            InitializeComponent();

            this.applicantId = applicantId;

            this.Text = "My Profile";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            SetEditMode(false);

            btnProfilePageEdit.Text = "Edit";

            btnProfilePageEdit.BackColor = Color.RoyalBlue;
            btnProfilePageEdit.ForeColor = Color.White;
            btnProfilePageEdit.FlatStyle = FlatStyle.Flat;
            btnProfilePageEdit.FlatAppearance.BorderSize = 0;
            btnProfilePageEdit.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void SetEditMode(bool editing)
        {
            txtBoxProfilePageFirstName.ReadOnly = !editing;
            txtBoxProfilePageLastName.ReadOnly = !editing;
            txtBoxProfilePageMiddleName.ReadOnly = !editing;

            txtBoxProfilePageEmail.ReadOnly = !editing;

            txtBoxProfilePageContact.ReadOnly = !editing;
            txtBoxProfilePageAltContact.ReadOnly = !editing;

            txtBoxProfilePageCurrentAddress.ReadOnly = !editing;
            txtBoxProfilePageState.ReadOnly = !editing;
            txtBoxProfilePagePostCode.ReadOnly = !editing;

            txtBoxProfilePageInstitution.ReadOnly = !editing;
            txtBoxProfilePageMajor.ReadOnly = !editing;

            cmbBoxProfilePageDegree.Enabled = editing;

            dtpProfilePageDOB.Enabled = editing;
            dtpProfilePageGraduationYear.Enabled = editing;

            radbtnProfilePageMale.Enabled = editing;
            radbtnProfilePageFemale.Enabled = editing;

            txtBoxProfilePageSkills.ReadOnly = !editing;
            btnProfilePageSkillsAdd.Enabled = editing;
            btnProfilePageSkillsRemove.Enabled = editing;
            btnProfilePageUploadPhoto.Enabled = editing;
            btnProfilePageChangePass.Enabled = editing;
        }

        private bool ValidateProfile()
        {
            MessageBox.Show("Validation Running");

            bool isValid = true;

            errorProviderProfilePage.Clear();

            // First Name
            if (string.IsNullOrWhiteSpace(txtBoxProfilePageFirstName.Text))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageFirstName,
                    "First Name is required."
                );
                isValid = false;
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(txtBoxProfilePageLastName.Text))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageLastName,
                    "Last Name is required."
                );
                isValid = false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtBoxProfilePageEmail.Text))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageEmail,
                    "Email is required."
                );
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtBoxProfilePageEmail.Text.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageEmail,
                    "Invalid Email Address."
                );
                isValid = false;
            }

            // Contact Number
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtBoxProfilePageContact.Text,
                @"^09\d{9}$"))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageContact,
                    "Enter a valid 11-digit mobile number."
                );
                isValid = false;
            }

            // Alternate Number
            if (!string.IsNullOrWhiteSpace(txtBoxProfilePageAltContact.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(
                    txtBoxProfilePageAltContact.Text,
                    @"^09\d{9}$"))
                {
                    errorProviderProfilePage.SetError(
                        txtBoxProfilePageAltContact,
                        "Enter a valid 11-digit mobile number."
                    );
                    isValid = false;
                }
            }

            // Address
            if (string.IsNullOrWhiteSpace(txtBoxProfilePageCurrentAddress.Text))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageCurrentAddress,
                    "Address is required."
                );
                isValid = false;
            }

            // Degree
            if (string.IsNullOrWhiteSpace(cmbBoxProfilePageDegree.Text))
            {
                errorProviderProfilePage.SetError(
                    cmbBoxProfilePageDegree,
                    "Select a degree."
                );
                isValid = false;
            }

            // Institution
            if (string.IsNullOrWhiteSpace(txtBoxProfilePageInstitution.Text))
            {
                errorProviderProfilePage.SetError(
                    txtBoxProfilePageInstitution,
                    "Institution is required."
                );
                isValid = false;
            }

            // DOB
            if (dtpProfilePageDOB.Value > DateTime.Today)
            {
                errorProviderProfilePage.SetError(
                    dtpProfilePageDOB,
                    "Birth date cannot be in the future."
                );

                isValid = false;
            }

            int age =
            DateTime.Today.Year -
            dtpProfilePageDOB.Value.Year;

            if (dtpProfilePageDOB.Value.Date >
                DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                errorProviderProfilePage.SetError(
                    dtpProfilePageDOB,
                    "Applicant must be at least 18 years old."
                );

                isValid = false;
            }

            // Profile Picture
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            return isValid;
        }
        private void SaveProfile()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string gender =
                    radbtnProfilePageMale.Checked
                    ? "Male"
                    : "Female";

                string query = @"
                UPDATE applicants
                SET
                    first_name=@fn,
                    last_name=@ln,
                    middle_name=@mn,
                    email=@em,
                    contact=@ct

                WHERE id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fn",
                    txtBoxProfilePageFirstName.Text);

                cmd.Parameters.AddWithValue("@ln",
                    txtBoxProfilePageLastName.Text);

                cmd.Parameters.AddWithValue("@mn",
                    txtBoxProfilePageMiddleName.Text);

                cmd.Parameters.AddWithValue("@em",
                    txtBoxProfilePageEmail.Text);

                cmd.Parameters.AddWithValue("@id",
                    applicantId);

                cmd.Parameters.AddWithValue("@ct",
                    txtBoxProfilePageContact.Text);

                cmd.ExecuteNonQuery();

                string profileQuery = @"
                INSERT INTO applicant_profiles
                (
                    applicant_id,
                    gender,
                    alternate_phone,
                    address,
                    province,
                    postal_code,
                    profile_picture
                )
                VALUES
                (
                    @id,
                    @gender,
                    @altphone,
                    @address,
                    @province,
                    @postcode,
                    @pic
                )
                ON DUPLICATE KEY UPDATE

                    gender=@gender,
                    alternate_phone=@altphone,
                    address=@address,
                    province=@province,
                    postal_code=@postcode,

                    profile_picture =
                    CASE
                    WHEN @pic IS NULL
                    THEN profile_picture
                    ELSE @pic
                END";

                    MySqlCommand cmd2 =
                        new MySqlCommand(profileQuery, conn);

                    cmd2.Parameters.AddWithValue("@id",
                        applicantId);

                    cmd2.Parameters.AddWithValue("@gender",
                        gender);

                    cmd2.Parameters.AddWithValue("@altphone",
                        txtBoxProfilePageAltContact.Text);

                    cmd2.Parameters.AddWithValue("@address",
                        txtBoxProfilePageCurrentAddress.Text);

                    cmd2.Parameters.AddWithValue("@province",
                        txtBoxProfilePageState.Text);

                    cmd2.Parameters.AddWithValue("@postcode",
                        txtBoxProfilePagePostCode.Text);

                if (profileImageBytes == null)
                {
                    cmd2.Parameters.AddWithValue("@pic", DBNull.Value);
                }
                else
                {
                    cmd2.Parameters.AddWithValue("@pic", profileImageBytes);
                }

                cmd2.ExecuteNonQuery();

                string eduQuery = @"
                INSERT INTO education
                (
                    applicant_id,
                    highest_degree,
                    institution_name,
                    field_of_study,
                    graduation_date
                )
                VALUES
                (
                    @id,
                    @degree,
                    @institution,
                    @major,
                    @grad
                )
                ON DUPLICATE KEY UPDATE

                highest_degree = @degree,
                institution_name = @institution,
                field_of_study = @major,
                graduation_date = @grad";

                MySqlCommand edu =
                    new MySqlCommand(eduQuery, conn);

                edu.Parameters.AddWithValue("@id",
                    applicantId);

                edu.Parameters.AddWithValue("@degree",
                    cmbBoxProfilePageDegree.Text);

                edu.Parameters.AddWithValue("@institution",
                    txtBoxProfilePageInstitution.Text);

                edu.Parameters.AddWithValue("@major",
                    txtBoxProfilePageMajor.Text);

                edu.Parameters.AddWithValue("@grad",
                    dtpProfilePageGraduationYear.Value);

                edu.ExecuteNonQuery();
                SaveSkills();
            }
        }

        private void LoadSkills()
        {
            lstBoxProfilePageSkills.Items.Clear();

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT skill_name
                FROM skills
                WHERE applicant_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", applicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstBoxProfilePageSkills.Items.Add(
                        reader["skill_name"].ToString());
                }

                reader.Close();
            }
        }

        private void SaveSkills()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string deleteQuery =
                @"DELETE FROM skills
                WHERE applicant_id=@id";

                MySqlCommand deleteCmd =
                    new MySqlCommand(deleteQuery, conn);

                deleteCmd.Parameters.AddWithValue(
                    "@id",
                    applicantId);

                deleteCmd.ExecuteNonQuery();

                foreach (var item in lstBoxProfilePageSkills.Items)
                {
                    string insertQuery =
                    @"INSERT INTO skills
                    (applicant_id, skill_name)
                    VALUES
                    (@id, @skill)";

                    MySqlCommand insertCmd =
                        new MySqlCommand(insertQuery, conn);

                    insertCmd.Parameters.AddWithValue(
                        "@id",
                        applicantId);

                    insertCmd.Parameters.AddWithValue(
                        "@skill",
                        item.ToString());

                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadApplicantPhoto()
        {
            using (MySqlConnection conn =
        new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT profile_picture
                FROM applicant_profiles
                WHERE applicant_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", applicantId);

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    profileImageBytes = (byte[])result;

                    using (MemoryStream ms =
                        new MemoryStream(profileImageBytes))
                    {
                        picBoxProfilePagepfp.Image =
                            Image.FromStream(ms);
                    }
                }
            }
        }

        private void LoadProfile()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    a.first_name,
                    a.last_name,
                    a.middle_name,
                    a.email,
                    a.birth_date,
                    a.contact,
                    ap.gender,
                    ap.alternate_phone,
                    ap.address,
                    ap.province,
                    ap.postal_code,
                    ap.profile_picture
                FROM applicants a
                LEFT JOIN applicant_profiles ap
                    ON a.id = ap.applicant_id
                WHERE a.id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", applicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtBoxProfilePageFirstName.Text =
                        reader["first_name"].ToString();

                    txtBoxProfilePageLastName.Text =
                        reader["last_name"].ToString();

                    txtBoxProfilePageMiddleName.Text =
                        reader["middle_name"].ToString();

                    txtBoxProfilePageEmail.Text =
                        reader["email"].ToString();

                    txtBoxProfilePageContact.Text =
                        reader["contact"].ToString();

                    txtBoxProfilePageAltContact.Text =
                        reader["alternate_phone"].ToString();

                    txtBoxProfilePageCurrentAddress.Text =
                        reader["address"].ToString();

                    txtBoxProfilePageState.Text =
                        reader["province"].ToString();

                    txtBoxProfilePagePostCode.Text =
                        reader["postal_code"].ToString();

                    if (reader["birth_date"] != DBNull.Value)
                    {
                        dtpProfilePageDOB.Value =
                            Convert.ToDateTime(reader["birth_date"]);
                    }

                    string gender =
                        reader["gender"].ToString();

                    if (gender == "Male")
                        radbtnProfilePageMale.Checked = true;

                    if (gender == "Female")
                        radbtnProfilePageFemale.Checked = true;

                    if (reader["profile_picture"] != DBNull.Value)
                    {
                        byte[] imgBytes =
                            (byte[])reader["profile_picture"];

                        using (MemoryStream ms =
                            new MemoryStream(imgBytes))
                        {
                            picBoxProfilePagepfp.Image =
                                Image.FromStream(ms);
                        }

                        profileImageBytes = imgBytes;
                    }
                }

                reader.Close();
            }

            LoadEducation();
            LoadSkills();
        }

        private void LoadEducation()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT * FROM education
                WHERE applicant_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                    applicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    cmbBoxProfilePageDegree.Text =
                        reader["highest_degree"].ToString();

                    txtBoxProfilePageInstitution.Text =
                        reader["institution_name"].ToString();

                    txtBoxProfilePageMajor.Text =
                        reader["field_of_study"].ToString();

                    if (reader["graduation_date"] != DBNull.Value)
                    {
                        dtpProfilePageGraduationYear.Value =
                            Convert.ToDateTime(
                            reader["graduation_date"]);
                    }
                }

                reader.Close();
            }
        }

        private void LettersOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnMyApllication_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxProfilePagepfp.Image =
                    Image.FromFile(ofd.FileName);

                profileImageBytes =
                    File.ReadAllBytes(ofd.FileName);
            }
        }

        private void NumbersOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void lblAltNumber_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_4(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profilepage_Load(object sender, EventArgs e)
        {
            LoadProfile();
            LoadApplicantPhoto();
        }

        private void btnProfilePageEdit_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                editMode = true;

                SetEditMode(true);

                btnProfilePageEdit.Text = "Update";
            }
            else
            {
                if (!ValidateProfile())
                    return;

                SaveProfile();

                editMode = false;

                SetEditMode(false);

                btnProfilePageEdit.Text = "Edit";

                MessageBox.Show("Profile Updated Successfully.");
            }

        }

        private void txtBoxProfilePageState_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpSkills_Click(object sender, EventArgs e)
        {

        }

        private void btnProfilePageSkillsAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxProfilePageSkills.Text))
            {
                MessageBox.Show("Enter a skill.");
                return;
            }

            lstBoxProfilePageSkills.Items.Add(txtBoxProfilePageSkills.Text.Trim());

            txtBoxProfilePageSkills.Clear();
        }

        private void btnProfilePageSkillsRemove_Click(object sender, EventArgs e)
        {
            if (lstBoxProfilePageSkills.SelectedIndex >= 0)
            {
                lstBoxProfilePageSkills.Items.RemoveAt(
                    lstBoxProfilePageSkills.SelectedIndex);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProfilePageDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.ApplicantId = applicantId;

            dashboard.Show();

            this.Hide();
        }

        private void txtBoxProfilePageFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LettersOnly(e);
        }

        private void txtBoxProfilePageLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LettersOnly(e);
        }

        private void txtBoxProfilePageMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LettersOnly(e);
        }

        private void txtBoxProfilePageContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly(e);
        }

        private void txtBoxProfilePageAltContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbersOnly(e);
        }
    }
}
