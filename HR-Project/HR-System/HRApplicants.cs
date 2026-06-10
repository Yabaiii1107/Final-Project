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
    public partial class HRApplicants : Form
    {
        string connectionString =
                "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        private DataTable dt = new DataTable();

        public HRApplicants()
        {
            InitializeComponent();
        }

        private void LoadApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    ap.id AS ApplicantID,
                    CONCAT(ap.first_name, ' ', ap.last_name) AS ApplicantName,
                    j.position AS PositionApplied,  
                    a.status AS Status
                FROM applicants ap
                LEFT JOIN applications a ON ap.id = a.applicant_id
                LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                dt.Clear();
                adapter.Fill(dt);

                dgvApplicants.DataSource = null;   // IMPORTANT RESET
                dgvApplicants.AutoGenerateColumns = true;
                dgvApplicants.DataSource = dt;
            }
        }

        private void LoadApplicantsFiltered()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        a.application_id AS ApplicationID,
                        ap.id AS ApplicantID,
                        CONCAT(ap.first_name, ' ', ap.last_name) AS ApplicantName,
                        j.position AS PositionApplied,
                        a.status AS Status
                    FROM applicants ap
                    LEFT JOIN applications a ON ap.id = a.applicant_id
                    LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtBoxSearchApplicant.Text))
                    query += " AND CONCAT(ap.first_name, ' ', ap.last_name) LIKE @search";

                if (cmbBoxFilterStatus.Text != "All")
                    query += " AND a.status = @status";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(txtBoxSearchApplicant.Text))
                    cmd.Parameters.AddWithValue("@search", "%" + txtBoxSearchApplicant.Text + "%");

                if (cmbBoxFilterStatus.Text != "All")
                    cmd.Parameters.AddWithValue("@status", cmbBoxFilterStatus.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvApplicants.DataSource = dt;
            }
        }

        private void LoadApplicantDetails(int applicantId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        ap.id,
                        CONCAT(ap.first_name,' ',ap.last_name) AS ApplicantName,
                        ap.first_name,
                        ap.last_name,
                        ap.email,
                        ap.contact,
                        j.position,
                        a.application_date,
                        a.status
                    FROM applicants ap
                    LEFT JOIN applications a
                        ON ap.id = a.applicant_id
                    LEFT JOIN job_vacancies j
                        ON a.vacancy_id = j.vacancy_id
                    WHERE ap.id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", applicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblApplicantID1.Text = reader["id"].ToString();

                        lblFullName1.Text =
                            reader["first_name"].ToString() + " " +
                            reader["last_name"].ToString();

                        lblEmail1.Text = reader["email"].ToString();
                        lblContactNumber1.Text = reader["contact"].ToString();

                        lblPositionApplied1.Text =
                            reader["position"]?.ToString() ?? "No application yet";

                        lblApplicationDate1.Text =
                            reader["application_date"] == DBNull.Value
                                ? "N/A"
                                : Convert.ToDateTime(reader["application_date"])
                                    .ToString("MMMM dd, yyyy");

                        cmbCurrentStatus.Text =
                            reader["status"]?.ToString() ?? "Pending";
                    }
                }

            }
        }

        private void btnResumeView_Click(object sender, EventArgs e)
        {

        }

        private void dgvApplicants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HRApplicants_Load(object sender, EventArgs e)
        {
            LoadApplicants();

            cmbBoxFilterStatus.Items.Clear();

            cmbBoxFilterStatus.Items.Add("All");
            cmbBoxFilterStatus.Items.Add("Submitted");
            cmbBoxFilterStatus.Items.Add("Under Review");
            cmbBoxFilterStatus.Items.Add("Shortlisted");
            cmbBoxFilterStatus.Items.Add("Interview");
            cmbBoxFilterStatus.Items.Add("Final Review");
            cmbBoxFilterStatus.Items.Add("Accepted");
            cmbBoxFilterStatus.Items.Add("Rejected");

            cmbBoxFilterStatus.SelectedIndex = 0;

            LoadApplicantsFiltered();

            cmbCurrentStatus.Items.Clear();

            cmbCurrentStatus.Items.Add("Under Review");
            cmbCurrentStatus.Items.Add("Shortlisted");
            cmbCurrentStatus.Items.Add("For Interview");
            cmbCurrentStatus.Items.Add("For Assessment");
            cmbCurrentStatus.Items.Add("Final Review");

            cmbCurrentStatus.Items.Add("Accepted");
            cmbCurrentStatus.Items.Add("Rejected");

            cmbCurrentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
            HRDashboard dashboard = new HRDashboard();
            dashboard.FormClosed += (s, args) => this.Show();
            this.Hide();
            dashboard.Show();
        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvApplicants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
                return;

            if (dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == null)
                return;

            if (!int.TryParse(dgvApplicants.CurrentRow.Cells["ApplicantID"].Value.ToString(), out int applicantId))
                return;

            LoadApplicantDetails(applicantId);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null) return;

            if (string.IsNullOrWhiteSpace(cmbCurrentStatus.Text))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            if (dgvApplicants.CurrentRow.Cells["ApplicationID"].Value == null ||
                dgvApplicants.CurrentRow.Cells["ApplicationID"].Value == DBNull.Value)
            {
                MessageBox.Show("No application selected.");
                return;
            }

            if (!int.TryParse(
                dgvApplicants.CurrentRow.Cells["ApplicationID"].Value.ToString(),
                out int applicationId))
            {
                MessageBox.Show("Invalid Application ID.");
                return;
            }

            if (!int.TryParse(
                dgvApplicants.CurrentRow.Cells["ApplicantID"].Value.ToString(),
                out int applicantId))
            {
                MessageBox.Show("Invalid Applicant ID.");
                return;
            }

            string selectedStatus = cmbCurrentStatus.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateQuery = @"
                UPDATE applications
                SET status = @status
                WHERE application_id = @id";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@status", selectedStatus);
                cmd.Parameters.AddWithValue("@id", applicationId);
                cmd.ExecuteNonQuery();

                string historyQuery = @"
                INSERT INTO application_status_history
                    (application_id, status, changed_at)
                VALUES
                    (@appId, @status, NOW())";

                MySqlCommand histCmd = new MySqlCommand(historyQuery, conn);
                histCmd.Parameters.AddWithValue("@appId", applicationId);
                histCmd.Parameters.AddWithValue("@status", selectedStatus);
                histCmd.ExecuteNonQuery();
            }

            TakeProfileSnapshotIfNeeded(applicationId, applicantId, selectedStatus);

            MessageBox.Show("Status updated successfully.");
            LoadApplicantsFiltered();
        }

        private static readonly HashSet<string> LockedStatuses = new HashSet<string>
{
        "Under Review", "Shortlisted", "Interview",
        "For Interview", "For Assessment", "Final Review",
        "Accepted", "Rejected"
};

        private void TakeProfileSnapshotIfNeeded(
            int applicationId, int applicantId, string newStatus)
        {
            if (!LockedStatuses.Contains(newStatus))
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
                SELECT COUNT(*) FROM application_profile_snapshots
                WHERE application_id = @appId";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@appId", applicationId);
                long existing = (long)checkCmd.ExecuteScalar();

                if (existing > 0) return;

                string insertQuery = @"
                INSERT INTO application_profile_snapshots
                (
                    application_id, applicant_id,
                    first_name, last_name, middle_name, birth_date,
                    email, contact,
                    gender, alternate_phone, address, province, postal_code,
                    profile_picture,
                    highest_degree, institution_name, field_of_study, graduation_date
                )
                SELECT
                    @appId, a.id,
                    a.first_name, a.last_name, a.middle_name, a.birth_date,
                    a.email, a.contact,
                    ap.gender, ap.alternate_phone, ap.address, ap.province, ap.postal_code,
                    ap.profile_picture,
                    ed.highest_degree, ed.institution_name, ed.field_of_study, ed.graduation_date
                FROM applicants a
                LEFT JOIN applicant_profiles ap ON a.id = ap.applicant_id
                LEFT JOIN education ed ON a.id = ed.applicant_id
                WHERE a.id = @applicantId";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@appId", applicationId);
                insertCmd.Parameters.AddWithValue("@applicantId", applicantId);
                insertCmd.ExecuteNonQuery();

                long snapshotId = insertCmd.LastInsertedId;

                string skillsQuery = @"
                SELECT skill_name FROM skills WHERE applicant_id = @id";
                MySqlCommand skillsCmd = new MySqlCommand(skillsQuery, conn);
                skillsCmd.Parameters.AddWithValue("@id", applicantId);

                using (MySqlDataReader skillReader = skillsCmd.ExecuteReader())
                {
                    List<string> skills = new List<string>();
                    while (skillReader.Read())
                        skills.Add(skillReader["skill_name"].ToString());
                    skillReader.Close();

                    foreach (var skill in skills)
                    {
                        string insertSkill = @"
                    INSERT INTO snapshot_skills (snapshot_id, skill_name)
                    VALUES (@snapId, @skill)";
                        MySqlCommand sc = new MySqlCommand(insertSkill, conn);
                        sc.Parameters.AddWithValue("@snapId", snapshotId);
                        sc.Parameters.AddWithValue("@skill", skill);
                        sc.ExecuteNonQuery();
                    }
                }

                string workQuery = @"
                SELECT company_name, position_title, employment_type,
                       start_date, end_date, currently_working, job_description
                FROM applicant_work_experience
                WHERE applicant_id = @id";
                MySqlCommand workCmd = new MySqlCommand(workQuery, conn);
                workCmd.Parameters.AddWithValue("@id", applicantId);

                using (MySqlDataReader workReader = workCmd.ExecuteReader())
                {
                    var rows = new List<object[]>();
                    while (workReader.Read())
                    {
                        rows.Add(new object[]
                        {
                    workReader["company_name"],
                    workReader["position_title"],
                    workReader["employment_type"],
                    workReader["start_date"],
                    workReader["end_date"],
                    workReader["currently_working"],
                    workReader["job_description"]
                        });
                    }
                    workReader.Close();

                    foreach (var row in rows)
                    {
                        string insertWork = @"
                    INSERT INTO snapshot_work_experience
                    (snapshot_id, company_name, position_title, employment_type,
                     start_date, end_date, currently_working, job_description)
                    VALUES
                    (@snapId, @co, @pos, @emp, @s, @e, @cw, @desc)";
                        MySqlCommand wc = new MySqlCommand(insertWork, conn);
                        wc.Parameters.AddWithValue("@snapId", snapshotId);
                        wc.Parameters.AddWithValue("@co", row[0]);
                        wc.Parameters.AddWithValue("@pos", row[1]);
                        wc.Parameters.AddWithValue("@emp", row[2]);
                        wc.Parameters.AddWithValue("@s", row[3]);
                        wc.Parameters.AddWithValue("@e", row[4]);
                        wc.Parameters.AddWithValue("@cw", row[5]);
                        wc.Parameters.AddWithValue("@desc", row[6]);
                        wc.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnSearchApplicant_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    ap.id AS ApplicantID,
                    CONCAT(ap.first_name, ' ', ap.last_name) AS ApplicantName,
                    j.position AS PositionApplied,
                    a.status AS Status
                FROM applicants ap
                LEFT JOIN applications a ON ap.id = a.applicant_id
                LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE CONCAT(ap.first_name, ' ', ap.last_name) LIKE @search";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtBoxSearchApplicant.Text.Trim() + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtSearch = new DataTable();
                adapter.Fill(dtSearch);

                dgvApplicants.DataSource = null;
                dgvApplicants.AutoGenerateColumns = true;
                dgvApplicants.DataSource = dtSearch;
            }

            LoadApplicantsFiltered();
        }

        private void btnProfilePageClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbBoxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadApplicantsFiltered();
        }

        private void btnSearchApplicant_TextChanged(object sender, EventArgs e)
        {
            LoadApplicantsFiltered();
        }

        private void btnJobVacanciesManagement_Click(object sender, EventArgs e)
        {
            JobVacancyManagement jobForm = new JobVacancyManagement();
            jobForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            jobForm.Show();
        }

        private void cmbCurrentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrentStatus.Text == "Accepted" || cmbCurrentStatus.Text == "Rejected")
            {
                string currentStatus = dgvApplicants.CurrentRow?.Cells["Status"]?.Value?.ToString();

                if (currentStatus != "Final Review")
                {
                    MessageBox.Show("Final decision is only allowed in Final Review stage.");
                    cmbCurrentStatus.Text = currentStatus;
                }
            }
        }

        private void btnRejectApplicant_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFullProfile_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == null ||
                dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == DBNull.Value ||
                dgvApplicants.CurrentRow.Cells["ApplicationID"].Value == null ||
                dgvApplicants.CurrentRow.Cells["ApplicationID"].Value == DBNull.Value)
            {
                MessageBox.Show("No applicant selected.");
                return;
            }

            if (!int.TryParse(
                    dgvApplicants.CurrentRow.Cells["ApplicantID"].Value.ToString(),
                    out int applicantId) ||
                !int.TryParse(
                    dgvApplicants.CurrentRow.Cells["ApplicationID"].Value.ToString(),
                    out int applicationId))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            profilepage profile = new profilepage(applicantId, applicationId, hrViewMode: true);
            profile.ShowDialog();
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
    }
}
