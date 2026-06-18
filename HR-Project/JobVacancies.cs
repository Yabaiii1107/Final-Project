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

        public int SelectedApplicationId { get; set; }

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
            if (HasAcceptedApplication())
            {
                btnApply.Visible = true;
                btnApply.Enabled = false;

                btnCancelApplication.Visible = false;

                return;
            }

            if (dgvJobVacancies.SelectedRows.Count == 0)
            {
                btnApply.Visible = true;
                btnApply.Enabled = false;
                btnCancelApplication.Visible = false;
                return;
            }

            string position = dgvJobVacancies.SelectedRows[0].Cells[0].Value?.ToString();
            Job selectedJob = jobs.FirstOrDefault(j => j.Position == position);

            if (selectedJob == null) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT status FROM applications
                WHERE applicant_id = @id
                  AND vacancy_id   = @vacancy
                  AND status NOT IN ('Withdrawn', 'Rejected')
                ORDER BY application_date DESC
                LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", applicantId);
                cmd.Parameters.AddWithValue("@vacancy", selectedJob.JobId);
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    btnApply.Visible = true;
                    btnApply.Enabled = true;
                    btnCancelApplication.Visible = false;
                }
                else
                {
                    string status = result.ToString();
                    bool canCancel = status == "Submitted";
                    btnApply.Visible = false;
                    btnCancelApplication.Visible = true;
                    btnCancelApplication.Enabled = canCancel;
                    btnCancelApplication.Text = canCancel ? "Cancel" : "Locked";
                    btnCancelApplication.ForeColor = canCancel ? Color.DarkRed : Color.Gray;
                }
            }
        }

        private bool HasAcceptedApplication()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT COUNT(*)
                FROM applications
                WHERE applicant_id = @id
                  AND status = 'Accepted'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", applicantId);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
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
                  FROM job_vacancies
                  WHERE status != 'Closed'";

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
            ApplicantTheme.Apply(this, "btnJobVacancies");

            LoadJobs();
            LoadDepartments();
            RefreshApplicationButtons();

            if (HasAcceptedApplication())
            {
                btnApply.Enabled = false;
            }
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
            if (HasAcceptedApplication())
            {
                MessageBox.Show(
                    "Congratulations! One of your applications has already been accepted.\n\n" +
                    "You can no longer apply for other job vacancies.",
                    "Application Closed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

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

                string rejectedVacancyQuery = @"
                SELECT COUNT(*) FROM applications
                WHERE applicant_id = @id
                  AND status       = 'Rejected'
                  AND vacancy_id   = @vacancy";

                MySqlCommand rejectedCheck = new MySqlCommand(rejectedVacancyQuery, conn);
                rejectedCheck.Parameters.AddWithValue("@id", applicantId);
                rejectedCheck.Parameters.AddWithValue("@vacancy", selectedJob.JobId);
                int rejectedCount = Convert.ToInt32(rejectedCheck.ExecuteScalar());

                if (rejectedCount > 0)
                {
                    MessageBox.Show(
                        "You have already been rejected for this position.\n" +
                        "You may apply for a different job vacancy.",
                        "Application Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string dupQuery = @"
                SELECT COUNT(*) FROM applications
                WHERE applicant_id = @id
                  AND vacancy_id   = @vacancy
                  AND status NOT IN ('Withdrawn', 'Rejected')";

                MySqlCommand dupCheck = new MySqlCommand(dupQuery, conn);
                dupCheck.Parameters.AddWithValue("@id", applicantId);
                dupCheck.Parameters.AddWithValue("@vacancy", selectedJob.JobId);
                int dupCount = Convert.ToInt32(dupCheck.ExecuteScalar());

                if (dupCount > 0)
                {
                    MessageBox.Show(
                        "You have already applied for this position.",
                        "Duplicate Application",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = @"
                INSERT INTO applications (applicant_id, vacancy_id, status, application_date)
                VALUES (@id, @vacancy, 'Submitted', NOW())";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@id", applicantId);
                insertCmd.Parameters.AddWithValue("@vacancy", selectedJob.JobId);
                insertCmd.ExecuteNonQuery();

                int newAppId = Convert.ToInt32(insertCmd.LastInsertedId);

                string historyQuery = @"
                INSERT INTO application_status_history (application_id, status, changed_at)
                VALUES (@appId, 'Submitted', NOW())";

                MySqlCommand histCmd = new MySqlCommand(historyQuery, conn);
                histCmd.Parameters.AddWithValue("@appId", newAppId);
                histCmd.ExecuteNonQuery();

                SaveApplicationSnapshot(conn, newAppId);
            }

            MessageBox.Show("Application submitted successfully!");
            RefreshApplicationButtons();
        }

        private List<string> GetMissingRequiredDocuments(MySqlConnection conn, string requirementsCsv)
        {
            List<string> missing = new List<string>();

            if (string.IsNullOrWhiteSpace(requirementsCsv))
                return missing;

            List<string> required = requirementsCsv
                .Split(',')
                .Select(r => r.Trim())
                .Where(r => r.Length > 0)
                .ToList();

            if (required.Count == 0)
                return missing;

            HashSet<string> uploadedTypes = new HashSet<string>();

            string query = @"
                SELECT document_type FROM applicant_documents
                WHERE applicant_id = @id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", applicantId);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    uploadedTypes.Add(NormalizeDocType(reader["document_type"].ToString()));
            }

            foreach (string req in required)
            {
                if (!uploadedTypes.Contains(NormalizeDocType(req)))
                    missing.Add(req);
            }

            return missing;
        }

        private string NormalizeDocType(string docType)
        {
            if (string.IsNullOrWhiteSpace(docType)) return "";

            string normalized = docType.Trim().ToLower();

            if (normalized == "resume" || normalized == "resume/cv" || normalized == "cv")
                return "resume";

            if (normalized == "government id" || normalized == "gov id" || normalized == "valid id")
                return "government id";

            return normalized;
        }

        private void SaveApplicationSnapshot(MySqlConnection conn, int applicationId)
        {

            string deleteSnap = @"
                DELETE FROM application_profile_snapshots
                WHERE application_id = @appId";
            MySqlCommand delCmd = new MySqlCommand(deleteSnap, conn);
            delCmd.Parameters.AddWithValue("@appId", applicationId);
            delCmd.ExecuteNonQuery();

            string snapQuery = @"
            INSERT INTO application_profile_snapshots
            (
                application_id,
                applicant_id,
                first_name, last_name, middle_name,
                email, contact, birth_date,
                gender, alternate_phone,
                address, province, postal_code,
                highest_degree, institution_name,
                field_of_study, graduation_date,
                profile_picture
            )
            SELECT
                @appId,
                @applicantId,
                a.first_name, a.last_name, a.middle_name,
                a.email, a.contact, a.birth_date,
                ap.gender, ap.alternate_phone,
                ap.address, ap.province, ap.postal_code,
                e.highest_degree, e.institution_name,
                e.field_of_study, e.graduation_date,
                ap.profile_picture
            FROM applicants a
            LEFT JOIN applicant_profiles ap ON a.id = ap.applicant_id
            LEFT JOIN education e            ON a.id = e.applicant_id
            WHERE a.id = @applicantId";


            MySqlCommand snapCmd = new MySqlCommand(snapQuery, conn);
            snapCmd.Parameters.AddWithValue("@appId", applicationId);
            snapCmd.Parameters.AddWithValue("@applicantId", applicantId);
            snapCmd.ExecuteNonQuery();

            long snapshotId = snapCmd.LastInsertedId;

            string deleteSkillSnap = @"
                DELETE FROM snapshot_skills WHERE snapshot_id = @snapId";
            MySqlCommand delSkillCmd = new MySqlCommand(deleteSkillSnap, conn);
            delSkillCmd.Parameters.AddWithValue("@snapId", snapshotId);
            delSkillCmd.ExecuteNonQuery();

            string skillSnapQuery = @"
                INSERT INTO snapshot_skills (snapshot_id, skill_name)
                SELECT @snapId, skill_name FROM skills
                WHERE applicant_id = @applicantId";
            MySqlCommand skillSnapCmd = new MySqlCommand(skillSnapQuery, conn);
            skillSnapCmd.Parameters.AddWithValue("@snapId", snapshotId);
            skillSnapCmd.Parameters.AddWithValue("@applicantId", applicantId);
            skillSnapCmd.ExecuteNonQuery();

            string deleteWorkSnap = @"
                DELETE FROM snapshot_work_experience WHERE snapshot_id = @snapId";
            MySqlCommand delWorkCmd = new MySqlCommand(deleteWorkSnap, conn);
            delWorkCmd.Parameters.AddWithValue("@snapId", snapshotId);
            delWorkCmd.ExecuteNonQuery();

            string workSnapQuery = @"
                INSERT INTO snapshot_work_experience
                (
                    snapshot_id, company_name, position_title,
                    employment_type, start_date, end_date,
                    currently_working, job_description
                )
                SELECT
                    @snapId, company_name, position_title,
                    employment_type, start_date, end_date,
                    currently_working, job_description
                FROM applicant_work_experience
                WHERE applicant_id = @applicantId";
            MySqlCommand workSnapCmd = new MySqlCommand(workSnapQuery, conn);
            workSnapCmd.Parameters.AddWithValue("@snapId", snapshotId);
            workSnapCmd.Parameters.AddWithValue("@applicantId", applicantId);
            workSnapCmd.ExecuteNonQuery();
        }

        private void btnProfilePageMyProfile_Click(object sender, EventArgs e)
        {
            profilepage profile = new profilepage(applicantId);
            profile.SelectedApplicationId = SelectedApplicationId;
            profile.FormClosed += (s, args) => this.Show();
            this.Hide();                               
            profile.Show();
        }

        private void btnProfilePageDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ApplicantId = applicantId;
            dashboard.SelectedApplicationId = SelectedApplicationId;
            dashboard.Show();
            this.Hide();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();
            doc.ApplicantId = applicantId;
            doc.SelectedApplicationId = SelectedApplicationId;
            doc.Show();
            this.Hide();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            ApplicantPage1 app = new ApplicantPage1();
            app.ApplicantId = applicantId;
            app.SelectedApplicationId = SelectedApplicationId;
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
            StatusTracking st = new StatusTracking(applicantId, SelectedApplicationId);
            st.Show();
            this.Hide();
        }

        private void btnCancelApplication_Click(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0) return;

            string position = dgvJobVacancies.SelectedRows[0].Cells[0].Value?.ToString();
            Job selectedJob = jobs.FirstOrDefault(j => j.Position == position);
            if (selectedJob == null) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
                SELECT application_id, status FROM applications
                WHERE applicant_id = @id
                  AND vacancy_id   = @vacancy
                  AND status NOT IN ('Withdrawn', 'Rejected')
                ORDER BY application_date DESC LIMIT 1";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", applicantId);
                checkCmd.Parameters.AddWithValue("@vacancy", selectedJob.JobId);

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
                        $"Cancel your application for {selectedJob.Position}?\n" +
                        "It will be marked as Withdrawn.",
                        "Confirm Cancellation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes) return;

                    string revertQuery = @"
                    UPDATE applications
                    SET status = 'Withdrawn'
                    WHERE application_id = @appId AND status = 'Submitted'";

                    MySqlCommand revertCmd = new MySqlCommand(revertQuery, conn);
                    revertCmd.Parameters.AddWithValue("@appId", applicationId);
                    int rows = revertCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Application cancelled. You may re-apply anytime.",
                            "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshApplicationButtons();
                    }
                    else
                    {
                        MessageBox.Show("Cancellation failed. Please try again.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvJobVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0) return;

            string position = dgvJobVacancies.SelectedRows[0].Cells[0].Value?.ToString();
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

            RefreshApplicationButtons();
        }
    }
}
