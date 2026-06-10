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

namespace HR_Project.HR_System
{
    public partial class JobVacancyManagement : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public JobVacancyManagement()
        {
            InitializeComponent();
        }

        private void LoadOpenJobs()
        {
            dgvVacancies.Rows.Clear();

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT vacancy_id, position
                FROM job_vacancies
                WHERE status='Open'";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvVacancies.Rows.Add(
                        reader["vacancy_id"],
                        reader["position"]);
                }
            }
        }

        private void txtQualInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtJobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
                System.Media.SystemSounds.Beep.Play(); 
            }
        }

        private void lblWelcomeHR_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveJobOpening_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                INSERT INTO job_vacancies
                (
                    position,
                    department,
                    employment_type,
                    status,
                    qualifications,
                    requirements
                )
                VALUES
                (
                    @position,
                    @department,
                    @employmentType,
                    'Open',
                    @qualifications,
                    @requirements
                )";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@position", txtJobTitle.Text);
                cmd.Parameters.AddWithValue("@department", cmbDepartment.Text);

                string qualifications =
                    string.Join(Environment.NewLine,
                    lstQualifications.Items.Cast<string>());

                List<string> docs = new List<string>();

                if (chkResume.Checked)
                    docs.Add("Resume");

                if (chkGovernmentID.Checked)
                    docs.Add("Government ID");

                if (chkTranscript.Checked)
                    docs.Add("Transcript");

                if (chkCertificates.Checked)
                    docs.Add("Certificates");

                string requirements =
                    string.Join(", ", docs);

                string employmentType = cmbEmploymentType.Text;

                cmd.Parameters.AddWithValue("@employmentType", employmentType);
                cmd.Parameters.AddWithValue("@qualifications", qualifications);
                cmd.Parameters.AddWithValue("@requirements", requirements);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Job vacancy created successfully.");

            LoadOpenJobs();
        }

        private void JobVacancyManagement_Load(object sender, EventArgs e)
        {
            LoadOpenJobs();
        }

        private void btnCloseJOb_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0)
                return;

            int vacancyId =
                Convert.ToInt32(
                    dgvVacancies.SelectedRows[0].Cells[0].Value);

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE job_vacancies
                SET status='Closed'
                WHERE vacancy_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", vacancyId);

                cmd.ExecuteNonQuery();
            }

            LoadOpenJobs();
        }

        private void btnActiveJob_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0)
                return;

            int vacancyId =
                Convert.ToInt32(
                    dgvVacancies.SelectedRows[0].Cells[0].Value);

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE job_vacancies
                SET status='Open'
                WHERE vacancy_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", vacancyId);

                cmd.ExecuteNonQuery();
            }

            LoadOpenJobs();
        }

        private void btnAddQual_Click(object sender, EventArgs e)
        {
            if (txtQualInfo.Text.Trim() == "")
                return;

            lstQualifications.Items.Add(txtQualInfo.Text.Trim());

            txtQualInfo.Clear();

            txtQualInfo.Focus();
        }

        private void btnMyDocumentsLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();

                login.Show();

                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HRDashboard dashboard = new HRDashboard();
            dashboard.FormClosed += (s, args) => this.Show();
            this.Hide();
            dashboard.Show();
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            HRApplicants applicants = new HRApplicants();
            applicants.FormClosed += (s, args) => this.Show();
            this.Hide();
            applicants.Show();
        }
    }
}
