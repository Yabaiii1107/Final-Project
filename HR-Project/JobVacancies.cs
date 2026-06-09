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
    public partial class JobVacancies : Form
    {
        public int applicantId;

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public JobVacancies()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private List<Job> jobs = new List<Job>();

        private void LoadJobs()
        {
            jobs.Clear();

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT *
                  FROM job_vacancies";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    jobs.Add(new Job
                    {
                        JobId =
                            Convert.ToInt32(
                            reader["vacancy_id"]),

                        Position =
                            reader["position"].ToString(),

                        Department =
                            reader["department"].ToString(),

                        EmploymentType =
                            reader["employment_type"].ToString(),

                        Status =
                            reader["status"].ToString(),

                        Qualifications =
                            reader["qualifications"].ToString(),

                        Requirements =
                            reader["requirements"].ToString()
                    });
                }

                reader.Close();
            }

            RefreshGrid(jobs);
        }

        private void RefreshGrid(List<Job> source)
        {
            dgvJobVacancies.Rows.Clear();

            foreach (Job job in source)
            {
                dgvJobVacancies.Rows.Add(
                    job.Position,
                    job.Department,
                    job.EmploymentType,
                    job.Status
                );
            }
        }

        private void JobVacancies_Load(object sender, EventArgs e)
        {
            LoadJobs();

            cmbDepartment.Items.Add("All");
            cmbDepartment.Items.Add("IT");
            cmbDepartment.Items.Add("Human Resources");
            cmbDepartment.Items.Add("Finance");

            cmbDepartment.SelectedIndex = 0;
        }

        private void dgvJobVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0)
                return;

            string position =
                dgvJobVacancies.SelectedRows[0]
                .Cells[0].Value.ToString();

            Job selectedJob =
                jobs.FirstOrDefault(j => j.Position == position);

            if (selectedJob != null)
            {
                lblPosition.Text =
                    selectedJob.Position;

                lblDepartments.Text =
                    selectedJob.Department;

                lblEmploymentType.Text =
                    selectedJob.EmploymentType;

                rtbQualification.Text =
                    selectedJob.Qualifications;

                rtbRequirements.Text =
                    selectedJob.Requirements;
            }
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            string keyword =
                txtSearchJob.Text.Trim().ToLower();

            var filtered =
                jobs.Where(j =>
                j.Position.ToLower().Contains(keyword))
                .ToList();

            RefreshGrid(filtered);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.Text == "All")
            {
                RefreshGrid(jobs);
                return;
            }

            var filtered =
                jobs.Where(j =>
                j.Department == cmbDepartment.Text)
                .ToList();

            RefreshGrid(filtered);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            string position =
                dgvJobVacancies.SelectedRows[0]
                .Cells[0].Value.ToString();

            Job selectedJob =
                jobs.FirstOrDefault(j => j.Position == position);

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string existingApplicationQuery = @"
                SELECT COUNT(*)
                FROM applications
                WHERE applicant_id = @applicant";

                MySqlCommand existingCmd =
                    new MySqlCommand(existingApplicationQuery, conn);

                existingCmd.Parameters.AddWithValue(
                    "@applicant",
                    applicantId);

                int existingCount =
                    Convert.ToInt32(existingCmd.ExecuteScalar());

                if (existingCount > 0)
                {
                    MessageBox.Show(
                        "You have already applied for a job. Only one application is allowed.",
                        "Application Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string insertQuery =
                @"INSERT INTO applications
                (
                    applicant_id,
                    vacancy_id,
                    status
                )
                VALUES
                (
                    @applicant,
                    @vacancy,
                    'Submitted'
                )";

                MySqlCommand insertCmd =
                    new MySqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue(
                    "@applicant",
                    applicantId);

                insertCmd.Parameters.AddWithValue(
                    "@vacancy",
                    selectedJob.JobId);

                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                "Application submitted successfully!");
        }

        private void btnProfilePageMyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();

            profilepage profile =
                Application.OpenForms["profilepage"]
                as profilepage;

            if (profile == null)
            {
                profile = new profilepage(applicantId);
            }

            profile.Show();
        }

        private void btnProfilePageDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.ApplicantId = applicantId;

            dashboard.Show();

            this.Hide();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();

            doc.ApplicantId = applicantId;

            doc.Show();
            this.Hide();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            ApplicantPage1 app =
                new ApplicantPage1();

            app.ApplicantId = applicantId;

            app.Show();

            this.Hide();
        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
