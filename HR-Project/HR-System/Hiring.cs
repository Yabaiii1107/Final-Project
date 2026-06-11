using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project.HR_System
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public string UserRole { get; set; } = "HR Staff";
        public string UserName { get; set; } = "";

        private int _selectedApplicationId = -1;
        private int _selectedApplicantId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetResolutionControlsEnabled(false);
            ApplyRoleRestrictions();
            LoadFinalReviewApplicants();
            WireNavButtons();

            btnHiringDecision.Enabled = false;

            dgvApplicantList.SelectionChanged += dgvApplicantList_SelectionChanged;
            btnCommitResolution.Click += btnCommitResolution_Click;
        }

        private void ApplyRoleRestrictions()
        {
            if (string.IsNullOrEmpty(UserRole))
            {
                MessageBox.Show(
                    "User role was not passed to this form.\nPlease log in again.",
                    "Role Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                new Login().Show();
                this.Close();
                return;
            }

            bool canAccept = UserRole == "Admin" || UserRole == "HR Manager";
            rbAccept.Visible = canAccept;
            rbAccept.Enabled = canAccept;

            if (!canAccept)
                lblDecisionHeading.Text = "Decision (HR Manager / Admin required to Accept):";
        }

        private void LoadFinalReviewApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                const string query = @"
                    SELECT
                        a.application_id                        AS ApplicationID,
                        ap.id                                   AS ApplicantID,
                        CONCAT(ap.first_name,' ',ap.last_name)  AS ApplicantName,
                        COALESCE(j.position, 'N/A')             AS Position,
                        a.status                                AS Status
                    FROM applicants ap
                    INNER JOIN applications a   ON ap.id = a.applicant_id
                    LEFT  JOIN job_vacancies j  ON a.vacancy_id = j.vacancy_id
                    WHERE a.status = 'Final Review'
                    ORDER BY a.application_date ASC";

                var adapter = new MySqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);

                dgvApplicantList.DataSource = null;
                dgvApplicantList.AutoGenerateColumns = true;
                dgvApplicantList.DataSource = dt;
            }
        }

        private void dgvApplicantList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApplicantList.CurrentRow == null) return;

            var row = dgvApplicantList.CurrentRow;

            if (row.Cells["ApplicationID"].Value == null ||
                row.Cells["ApplicantID"].Value == null) return;

            _selectedApplicationId = Convert.ToInt32(row.Cells["ApplicationID"].Value);
            _selectedApplicantId = Convert.ToInt32(row.Cells["ApplicantID"].Value);

            txtApplicantName.Text = row.Cells["ApplicantName"].Value?.ToString() ?? "";
            txtPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";

            LoadDossier();
            ResetResolutionPanel();
            SetResolutionControlsEnabled(true);
        }

        private void LoadDossier()
        {
            txtScreenStatus.Text = "—";
            txtInterviewScore.Text = "—";
            txtPanelRec.Text = "—";

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                const string query = @"
                    SELECT update_message
                    FROM   updates
                    WHERE  applicant_id = @id
                    ORDER  BY created_at DESC";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _selectedApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string msg = reader["update_message"].ToString();

                        if (msg.StartsWith("[Screening]") && txtScreenStatus.Text == "—")
                        {
                            txtScreenStatus.Text = msg.Replace("[Screening]", "").Trim();
                        }

                        if (msg.StartsWith("[Interview Evaluation]") && txtInterviewScore.Text == "—")
                        {
                            string body = msg.Replace("[Interview Evaluation]", "").Trim();
                            string result = body.Contains("PASSED") ? "PASSED" : "FAILED";
                            txtInterviewScore.Text = result + " — " + body;

                            int recIdx = body.LastIndexOf("Recommendation:", StringComparison.OrdinalIgnoreCase);
                            if (recIdx >= 0)
                                txtPanelRec.Text = body.Substring(recIdx + "Recommendation:".Length).Trim();
                        }
                    }
                }
            }
        }

        private void btnCommitResolution_Click(object sender, EventArgs e)
        {
            if (_selectedApplicationId < 0)
            {
                MessageBox.Show(
                    "Please select an applicant first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!rbAccept.Checked && !rbHold.Checked && !rbReject.Checked)
            {
                MessageBox.Show(
                    "Please choose Accept, Hold, or Reject before committing.",
                    "No Decision",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (rbAccept.Checked && UserRole == "HR Staff")
            {
                MessageBox.Show(
                    "Only an HR Manager or Admin can mark an applicant as Accepted.\nPlease escalate to a manager.",
                    "Insufficient Permissions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            string newStatus;
            string decisionLabel;

            if (rbAccept.Checked)
            {
                newStatus = "Accepted";
                decisionLabel = "ACCEPTED";
            }
            else if (rbReject.Checked)
            {
                newStatus = "Rejected";
                decisionLabel = "REJECTED";
            }
            else
            {
                newStatus = "Final Review";
                decisionLabel = "ON HOLD";
            }

            DialogResult confirm = MessageBox.Show(
                $"Commit decision for {txtApplicantName.Text}?\n\n" +
                $"Decision:    {decisionLabel}\n" +
                $"Next Status: {newStatus}\n\n" +
                "This cannot be undone.",
                "Confirm Hiring Decision",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                CommitDecision(newStatus, decisionLabel);

                MessageBox.Show(
                    $"Decision committed for {txtApplicantName.Text}.\nStatus: {newStatus}",
                    "Decision Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ResetAll();
                LoadFinalReviewApplicants();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while saving the decision:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CommitDecision(string newStatus, string decisionLabel)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                if (newStatus != "Final Review")
                {
                    const string updateSql = @"
                        UPDATE applications
                        SET    status = @status
                        WHERE  application_id = @id";

                    var updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@status", newStatus);
                    updateCmd.Parameters.AddWithValue("@id", _selectedApplicationId);
                    updateCmd.ExecuteNonQuery();

                    const string historySql = @"
                        INSERT INTO application_status_history
                            (application_id, status, changed_at)
                        VALUES
                            (@id, @status, NOW())";

                    var histCmd = new MySqlCommand(historySql, conn);
                    histCmd.Parameters.AddWithValue("@id", _selectedApplicationId);
                    histCmd.Parameters.AddWithValue("@status", newStatus);
                    histCmd.ExecuteNonQuery();
                }

                string note =
                    $"[Hiring Decision] {decisionLabel}" +
                    (string.IsNullOrWhiteSpace(txtRemarks.Text)
                        ? ""
                        : $" — Remarks: {txtRemarks.Text.Trim()}") +
                    $" | Decided by: {UserName} ({UserRole})";

                const string notesSql = @"
                    INSERT INTO updates
                        (applicant_id, update_message, created_at)
                    VALUES
                        (@applicantId, @msg, NOW())";

                var noteCmd = new MySqlCommand(notesSql, conn);
                noteCmd.Parameters.AddWithValue("@applicantId", _selectedApplicantId);
                noteCmd.Parameters.AddWithValue("@msg", note);
                noteCmd.ExecuteNonQuery();

                TakeSnapshotIfNeeded(conn, _selectedApplicationId);
            }
        }

        private void TakeSnapshotIfNeeded(MySqlConnection conn, int applicationId)
        {
            const string checkSql = @"
                SELECT COUNT(*) FROM application_profile_snapshots
                WHERE  application_id = @id";

            var checkCmd = new MySqlCommand(checkSql, conn);
            checkCmd.Parameters.AddWithValue("@id", applicationId);
            if (Convert.ToInt64(checkCmd.ExecuteScalar()) > 0) return;

            const string insertSql = @"
                INSERT INTO application_profile_snapshots
                    (application_id, applicant_id,
                     first_name, last_name, middle_name, birth_date,
                     email, contact,
                     gender, alternate_phone, address, province, postal_code,
                     profile_picture,
                     highest_degree, institution_name, field_of_study, graduation_date)
                SELECT
                     @appId, a.id,
                     a.first_name, a.last_name, a.middle_name, a.birth_date,
                     a.email, a.contact,
                     ap.gender, ap.alternate_phone, ap.address,
                     ap.province, ap.postal_code, ap.profile_picture,
                     ed.highest_degree, ed.institution_name,
                     ed.field_of_study, ed.graduation_date
                FROM applicants a
                LEFT JOIN applicant_profiles ap ON a.id = ap.applicant_id
                LEFT JOIN education           ed ON a.id = ed.applicant_id
                WHERE a.id = (
                    SELECT applicant_id FROM applications
                    WHERE  application_id = @appId)";

            var insertCmd = new MySqlCommand(insertSql, conn);
            insertCmd.Parameters.AddWithValue("@appId", applicationId);
            insertCmd.ExecuteNonQuery();
        }

        private void SetResolutionControlsEnabled(bool enabled)
        {
            rbAccept.Enabled = enabled && (UserRole == "Admin" || UserRole == "HR Manager");
            rbHold.Enabled = enabled;
            rbReject.Enabled = enabled;
            txtRemarks.Enabled = enabled;
            btnCommitResolution.Enabled = enabled;
        }

        private void ResetResolutionPanel()
        {
            rbAccept.Checked = false;
            rbHold.Checked = false;
            rbReject.Checked = false;
            txtRemarks.Clear();
        }

        private void ResetAll()
        {
            txtApplicantName.Clear();
            txtPosition.Clear();
            txtScreenStatus.Clear();
            txtInterviewScore.Clear();
            txtPanelRec.Clear();
            ResetResolutionPanel();
            _selectedApplicationId = -1;
            _selectedApplicantId = -1;
            SetResolutionControlsEnabled(false);
        }

        private void WireNavButtons()
        {
            btnApplicants.Click += (s, e) => NavigateTo(
                () => new HRApplicants { UserRole = UserRole, UserName = UserName });

            btnJobVacanciesManagement.Click += (s, e) => NavigateTo(
                () => new JobVacancyManagement { UserRole = UserRole, UserName = UserName });

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

            btnScreening.Enabled = false;
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) => this.Show();
            this.Hide();
            next.Show();
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void btnScreening_Click(object sender, EventArgs e)
        {
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
        }
    }
}
