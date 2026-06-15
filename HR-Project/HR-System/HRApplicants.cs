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
        public string UserRole { get; set; } = "";
        public string UserName { get; set; } = "";

        private DataTable dt = new DataTable();

        public HRApplicants()
        {
            InitializeComponent();
        }

        private void ViewDocument(string documentType)
        {
            if (dgvApplicants.CurrentRow == null ||
                dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == null)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (!int.TryParse(
                    dgvApplicants.CurrentRow.Cells["ApplicantID"].Value.ToString(),
                    out int applicantId))
            {
                MessageBox.Show("Invalid Applicant ID.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT file_name, file_data
                FROM applicant_documents
                WHERE applicant_id   = @id
                  AND document_type  LIKE @type
                ORDER BY upload_date DESC
                LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", applicantId);
                cmd.Parameters.AddWithValue("@type", "%" + documentType + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show(
                            $"No {documentType} found for this applicant.",
                            "No Document",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    string fileName = reader["file_name"].ToString();
                    byte[] fileData = (byte[])reader["file_data"];

                    string tempPath = System.IO.Path.Combine(
                        System.IO.Path.GetTempPath(), fileName);

                    System.IO.File.WriteAllBytes(tempPath, fileData);

                    System.Diagnostics.Process.Start(
                        new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = tempPath,
                            UseShellExecute = true
                        });
                }
            }
        }

        private void LoadApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    ap.id                                    AS ApplicantID,
                    CONCAT(ap.first_name, ' ', ap.last_name) AS ApplicantName,
                    COALESCE(j.position, 'No position yet')  AS PositionApplied,
                    COALESCE(a.status,   'Draft')            AS Status
                FROM applicants ap
                LEFT JOIN applications a  ON ap.id = a.applicant_id
                LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                dt.Clear();
                adapter.Fill(dt);

                dgvApplicants.DataSource = null;
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
                    a.application_id                        AS ApplicationID,
                    ap.id                                   AS ApplicantID,
                    CONCAT(ap.first_name, ' ', ap.last_name) AS ApplicantName,
                    COALESCE(j.position, 'No position yet') AS PositionApplied,
                    COALESCE(a.status,   'Draft')           AS Status
                FROM applicants ap
                LEFT JOIN applications a  ON ap.id = a.applicant_id
                LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtBoxSearchApplicant.Text))
                    query += " AND CONCAT(ap.first_name, ' ', ap.last_name) LIKE @search";

                if (cmbBoxFilterStatus.Text != "All")
                    query += " AND COALESCE(a.status, 'Draft') = @status";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(txtBoxSearchApplicant.Text))
                    cmd.Parameters.AddWithValue("@search",
                        "%" + txtBoxSearchApplicant.Text + "%");

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
                    ap.first_name,
                    ap.last_name,
                    ap.email,
                    ap.contact,
                    COALESCE(j.position, 'No position yet') AS position,
                    a.application_date,
                    COALESCE(a.status, 'Draft')             AS status
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
                        lblFullName1.Text = reader["first_name"] + " " + reader["last_name"];
                        lblEmail1.Text = reader["email"].ToString();
                        lblContactNumber1.Text = reader["contact"].ToString();
                        lblPositionApplied1.Text = reader["position"].ToString();

                        lblApplicationDate1.Text =
                            reader["application_date"] == DBNull.Value
                            ? "N/A"
                            : Convert.ToDateTime(reader["application_date"])
                                .ToString("MMMM dd, yyyy");

                        cmbCurrentStatus.Text = reader["status"].ToString();
                    }
                }
            }
        }

        private void WireNavButtons()
        {
            btnMyDocumentsDashboard.Click += (s, e) => NavigateTo(
                () => new HRDashboard { UserRole = UserRole, UserName = UserName });

            btnJobVacanciesManagement.Click += (s, e) => NavigateTo(
                () => new JobVacancyManagement { UserRole = UserRole, UserName = UserName });

            btnScreening.Click += (s, e) => NavigateTo(
                () => new Screening { UserRole = UserRole, UserName = UserName });

            btnInterviews.Click += (s, e) => NavigateTo(
                () => new InterviewEvaluation { UserRole = UserRole, UserName = UserName });

            btnHiringDecision.Click += (s, e) => NavigateTo(
                () => new Form1 { UserRole = UserRole, UserName = UserName });

            btnReports.Click += (s, e) => NavigateTo(
                () => new ReportsModule { UserRole = UserRole, UserName = UserName });

            btnMyDocumentsLogout.Click += (s, e) =>
            {
                if (MessageBox.Show("Are you sure you want to logout?",
                        "Logout", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Login().Show();
                    this.Hide();
                }
            };

            btnProfilePageClose.Click += (s, e) => Application.Exit();

            btnApplicants.Enabled = false;
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) => this.Show();
            this.Hide();
            next.Show();
        }

        private void btnResumeView_Click(object sender, EventArgs e)
        {
            ViewDocument("Resume");
        }

        private void dgvApplicants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void HRApplicants_Load(object sender, EventArgs e)
        {

            UITheme.StyleForm(this);
            UITheme.StyleHeader(panelHeader, lblTitle);
            UITheme.StyleHeaderButton(btnProfilePageClose);
            UITheme.StyleLogoutButton(btnMyDocumentsLogout);
            UITheme.StyleNav(panelNavigation);
            foreach (Control c in panelNavigation.Controls)
                if (c is Button b) UITheme.StyleNavButton(b, b == btnApplicants);

            UITheme.StyleGrid(dgvApplicants);
            UITheme.StyleTextBox(txtBoxSearchApplicant);
            UITheme.StyleComboBox(cmbBoxFilterStatus);
            UITheme.StyleComboBox(cmbCurrentStatus);
            UITheme.StylePrimaryButton(btnUpdateStatus, UITheme.AccentBlue);
            UITheme.StylePrimaryButton(btnScheduleInterview, UITheme.AccentGreen);
            UITheme.StyleSecondaryButton(btnViewFullProfile);
            UITheme.StyleSecondaryButton(btnSearchApplicant);

            WireNavButtons();
            LoadApplicants();

            cmbBoxFilterStatus.Items.Clear();
            cmbBoxFilterStatus.Items.AddRange(new string[]
            {
                "All", "Draft", "Submitted", "Under Review", "Shortlisted",
                "Interview", "Final Review", "Accepted", "Rejected", "Withdrawn"
            });
            cmbBoxFilterStatus.SelectedIndex = 0;

            LoadApplicantsFiltered();

            cmbCurrentStatus.Items.Clear();
            cmbCurrentStatus.Items.AddRange(new string[]
            {
                "Draft", "Submitted", "Under Review", "Shortlisted",
                "Interview", "For Assessment", "Final Review",
                "Accepted", "Rejected", "Withdrawn"
            });
            cmbCurrentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvApplicants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null) return;

            if (dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == null) return;

            if (!int.TryParse(
                dgvApplicants.CurrentRow.Cells["ApplicantID"].Value.ToString(),
                out int applicantId)) return;

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
            string currentStatus = "";

            using (MySqlConnection connCheck = new MySqlConnection(connectionString))
            {
                connCheck.Open();
                string checkQuery = @"
                SELECT status FROM applications
                WHERE application_id = @id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connCheck);
                checkCmd.Parameters.AddWithValue("@id", applicationId);
                currentStatus = checkCmd.ExecuteScalar()?.ToString() ?? "";
            }

            if (currentStatus == "Withdrawn")
            {
                MessageBox.Show(
                    "This applicant has withdrawn their application.\n" +
                    "Their status cannot be changed.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (currentStatus == "Accepted" || currentStatus == "Rejected")
            {
                MessageBox.Show(
                    $"This application is already {currentStatus}.\n" +
                    "No further status changes are allowed.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (selectedStatus == "Draft" || selectedStatus == "Withdrawn")
            {
                MessageBox.Show(
                    $"Cannot manually set status to '{selectedStatus}'.\n" +
                    "Draft and Withdrawn are applicant-only statuses.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

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
            "For Assessment", "Final Review",
            "Accepted", "Rejected"
        };

        private void TakeProfileSnapshotIfNeeded(
            int applicationId, int applicantId, string newStatus)
        {
            if (!LockedStatuses.Contains(newStatus)) return;

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
            LoadApplicantsFiltered();
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
        }

        private void cmbCurrentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrentStatus.Text == "Accepted" || cmbCurrentStatus.Text == "Rejected")
            {
                string currentStatus =
                    dgvApplicants.CurrentRow?.Cells["Status"]?.Value?.ToString();

                if (currentStatus != "Final Review")
                {
                    MessageBox.Show("Final decision is only allowed in Final Review stage.");
                    cmbCurrentStatus.Text = currentStatus;
                }
            }
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
                new Login().Show();
                this.Hide();
            }
        }

        private void btnGovernmentIDView_Click(object sender, EventArgs e)
        {
            ViewDocument("Government ID");
        }

        private void btnTranscriptView_Click(object sender, EventArgs e)
        {
            ViewDocument("Transcript");
        }

        private void btnCertificatesView_Click(object sender, EventArgs e)
        {
            ViewDocument("Certificate");
        }

        private void btnResumeView_Click_1(object sender, EventArgs e)
        {
            ViewDocument("Resume");
        }

        private void btnScreening_Click(object sender, EventArgs e)
        {
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
        }

        private void btnHiringDecision_Click(object sender, EventArgs e)
        {
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void btnScheduleInterview_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (dgvApplicants.CurrentRow.Cells["ApplicationID"].Value == null ||
                dgvApplicants.CurrentRow.Cells["ApplicationID"].Value == DBNull.Value ||
                dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == null ||
                dgvApplicants.CurrentRow.Cells["ApplicantID"].Value == DBNull.Value)
            {
                MessageBox.Show("No application found for this applicant.");
                return;
            }

            string currentStatus =
                dgvApplicants.CurrentRow.Cells["Status"]?.Value?.ToString() ?? "";

            if (currentStatus != "Shortlisted")
            {
                MessageBox.Show(
                    "Only Shortlisted applicants can be scheduled for an interview.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Schedule schedule = new Schedule
            {
                ApplicationId = Convert.ToInt32(dgvApplicants.CurrentRow.Cells["ApplicationID"].Value),
                ApplicantId = Convert.ToInt32(dgvApplicants.CurrentRow.Cells["ApplicantID"].Value),
                ApplicantName = dgvApplicants.CurrentRow.Cells["ApplicantName"].Value?.ToString() ?? "",
                Position = dgvApplicants.CurrentRow.Cells["PositionApplied"].Value?.ToString() ?? ""
            };

            schedule.FormClosed += (s, args) => LoadApplicantsFiltered();
            schedule.ShowDialog();
        }
    }
}
