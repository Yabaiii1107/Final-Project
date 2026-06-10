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

        private void LoadDepartments()
        {
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.Add("All");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT DISTINCT department
                FROM job_vacancies
                ORDER BY department ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        cmbDepartment.Items.Add(reader["department"].ToString());
                }
            }

            cmbDepartment.SelectedIndex = 0;
        }

        private void RefreshApplicationButtons()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT status FROM applications
                WHERE applicant_id = @id
                ORDER BY application_date DESC
                LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", applicantId);
                object result = cmd.ExecuteScalar();

                string status = result?.ToString() ?? "Draft";

                if (status == "Draft")
                {
                    btnApply.Visible = true;
                    btnApply.Enabled = true;
                    btnCancelApplication.Visible = false;
                }
                else
                {
                    bool canCancel = status == "Submitted";

                    btnApply.Visible = false;
                    btnCancelApplication.Visible = true;
                    btnCancelApplication.Enabled = canCancel;
                    btnCancelApplication.Text = canCancel ? "Cancel" : "Locked";
                    btnCancelApplication.ForeColor = canCancel
                        ? System.Drawing.Color.DarkRed
                        : System.Drawing.Color.Gray;
                }
            }
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
            EnsureDraftExists();

            LoadJobs();

            EnsureDraftExists();
            LoadJobs();
            LoadDepartments();  
            RefreshApplicationButtons();

            RefreshApplicationButtons();
        }

        private void EnsureDraftExists()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
                SELECT COUNT(*) FROM applications
                WHERE applicant_id = @id";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", applicantId);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0) return;

                string insertQuery = @"
                INSERT INTO applications
                    (applicant_id, vacancy_id, status)
                VALUES
                    (@id, NULL, 'Draft')";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@id", applicantId);
                insertCmd.ExecuteNonQuery();
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

            string position = dgvJobVacancies.SelectedRows[0].Cells[0].Value.ToString();
            Job selectedJob = jobs.FirstOrDefault(j => j.Position == position);

            if (selectedJob == null) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
                SELECT status FROM applications
                WHERE applicant_id = @id
                ORDER BY application_date DESC
                LIMIT 1";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", applicantId);
                string status = checkCmd.ExecuteScalar()?.ToString() ?? "Draft";

                if (status != "Draft")
                {
                    MessageBox.Show(
                        "You have already submitted an application.",
                        "Application Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string updateQuery = @"
                UPDATE applications
                SET
                    vacancy_id       = @vacancy,
                    status           = 'Submitted',
                    application_date = NOW()
                WHERE applicant_id = @id
                  AND status       = 'Draft'";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@vacancy", selectedJob.JobId);
                updateCmd.Parameters.AddWithValue("@id", applicantId);
                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Application submitted successfully!");
            RefreshApplicationButtons();
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

        private void btnProfilePageLogout_Click(object sender, EventArgs e)
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

        private void btnStatusTracking_Click(object sender, EventArgs e)
        {
            StatusTracking st = new StatusTracking(applicantId);
            st.Show();
            this.Hide();
        }

        private void btnCancelApplication_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
                SELECT application_id, status
                FROM applications
                WHERE applicant_id = @id
                ORDER BY application_date DESC
                LIMIT 1";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", applicantId);

                using (MySqlDataReader reader = checkCmd.ExecuteReader())
                {
                    if (!reader.Read()) { MessageBox.Show("No application found."); return; }

                    string status = reader["status"].ToString();
                    int applicationId = Convert.ToInt32(reader["application_id"]);
                    reader.Close();

                    if (status != "Submitted")
                    {
                        MessageBox.Show(
                            "Your application can no longer be cancelled.\n" +
                            "HR has already started reviewing it.",
                            "Cannot Cancel",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        RefreshApplicationButtons();
                        return;
                    }

                    DialogResult confirm = MessageBox.Show(
                        "Are you sure you want to cancel your application?\n" +
                        "Your status will return to Draft.",
                        "Confirm Cancellation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes) return;

                    string revertQuery = @"
                    UPDATE applications
                    SET
                        status     = 'Draft',
                        vacancy_id = NULL
                    WHERE application_id = @appId
                      AND status         = 'Submitted'";

                    MySqlCommand revertCmd = new MySqlCommand(revertQuery, conn);
                    revertCmd.Parameters.AddWithValue("@appId", applicationId);
                    int rows = revertCmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show(
                            "Application cancelled. You may re-apply anytime.",
                            "Cancelled",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show(
                            "Cancellation failed. Please try again.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }

        private void dgvJobVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0)
                return;

            string position =
                dgvJobVacancies.SelectedRows[0].Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(position)) return;

            Job selectedJob = jobs.FirstOrDefault(j => j.Position == position);

            if (selectedJob != null)
            {
                lblPosition.Text = selectedJob.Position;
                lblDepartments.Text = selectedJob.Department;
                lblEmploymentType.Text = selectedJob.EmploymentType;
                rtbQualification.Text = selectedJob.Qualifications;
                rtbRequirements.Text = selectedJob.Requirements;
            }
        }
    }
}
