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

    public partial class profilepage : Form
    {
        private bool editMode = false;

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
            dateTimePicker1.Enabled = editing;

            radbtnProfilePageMale.Enabled = editing;
            radbtnProfilePageFemale.Enabled = editing;

            rtxtProfilePageSkills.ReadOnly = !editing;
            rtxtProfilePageWorkExp.ReadOnly = !editing;
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
                    postal_code
                )
                VALUES
                (
                    @id,
                    @gender,
                    @altphone,
                    @address,
                    @province,
                    @postcode
                )
                ON DUPLICATE KEY UPDATE

                    gender=@gender,
                    alternate_phone=@altphone,
                    address=@address,
                    province=@province,
                    postal_code=@postcode";

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
                )";

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
                    dateTimePicker1.Value);

                edu.ExecuteNonQuery();

                SaveSkills(conn);
                SaveWorkExperience(conn);
            }
        }

        private void SaveSkills(MySqlConnection conn)
        {
            string deleteQuery =
                "DELETE FROM skills WHERE applicant_id=@id";

            MySqlCommand deleteCmd =
                new MySqlCommand(deleteQuery, conn);

            deleteCmd.Parameters.AddWithValue("@id", applicantId);

            deleteCmd.ExecuteNonQuery();

            string[] skills =
                rtxtProfilePageSkills.Text
                .Split(new[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string skill in skills)
            {
                string insertQuery =
                    @"INSERT INTO skills
                    (applicant_id, skill_name)
                    VALUES
                    (@id, @skill)";

                MySqlCommand cmd =
                    new MySqlCommand(insertQuery, conn);

                cmd.Parameters.AddWithValue("@id", applicantId);
                cmd.Parameters.AddWithValue("@skill", skill.Trim());

                cmd.ExecuteNonQuery();
            }
        }

        private void SaveWorkExperience(MySqlConnection conn)
        {
            string deleteQuery =
                "DELETE FROM work_experience WHERE applicant_id=@id";

            MySqlCommand deleteCmd =
                new MySqlCommand(deleteQuery, conn);

            deleteCmd.Parameters.AddWithValue("@id", applicantId);

            deleteCmd.ExecuteNonQuery();

            string[] experiences =
                rtxtProfilePageWorkExp.Text
                .Split(new[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string exp in experiences)
            {
                string[] parts = exp.Split('-');

                if (parts.Length >= 2)
                {
                    string company =
                        parts[0].Trim();

                    string position =
                        parts[1].Trim();

                    string query =
                        @"INSERT INTO work_experience
                        (
                            applicant_id,
                            company_name,
                            position_title
                        )
                        VALUES
                        (
                            @id,
                            @company,
                            @position
                        )";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", applicantId);
                    cmd.Parameters.AddWithValue("@company", company);
                    cmd.Parameters.AddWithValue("@position", position);

                    cmd.ExecuteNonQuery();
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
                ap.postal_code

                FROM applicants a

                LEFT JOIN applicant_profiles ap
                ON a.id = ap.applicant_id

                WHERE a.id=@id";

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
                }

                reader.Close();
            }

            LoadEducation();
            LoadSkills();
            LoadWorkExperience();
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
                        dateTimePicker1.Value =
                            Convert.ToDateTime(
                            reader["graduation_date"]);
                    }
                }

                reader.Close();
            }
        }

        private void LoadSkills()
        {
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

                cmd.Parameters.AddWithValue("@id",
                    applicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                rtxtProfilePageSkills.Clear();

                while (reader.Read())
                {
                    rtxtProfilePageSkills.AppendText(
                        reader["skill_name"].ToString()
                        + Environment.NewLine);
                }

                reader.Close();
            }
        }

        private void LoadWorkExperience()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT company_name,
                position_title
                FROM work_experience
                WHERE applicant_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                    applicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                rtxtProfilePageWorkExp.Clear();

                while (reader.Read())
                {
                    rtxtProfilePageWorkExp.AppendText(
                        reader["company_name"] +
                        " - " +
                        reader["position_title"] +
                        Environment.NewLine);
                }

                reader.Close();
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
    }
}
