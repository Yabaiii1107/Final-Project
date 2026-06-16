using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project.HR_System
{
    public partial class Screening : Form
    {
        private string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public string UserRole { get; set; } = "";
        public string UserName { get; set; } = "";

        private int _selectedApplicationId = -1;
        private int _selectedApplicantId = -1;

        public Screening()
        {
            InitializeComponent();
        }

        private void Screening_Load(object sender, EventArgs e)
        {
            UITheme.StyleForm(this);
            UITheme.StyleHeader(panelHeader, lblTitle);
            UITheme.StyleHeaderButton(btnProfilePageClose);
            UITheme.StyleLogoutButton(btnMyDocumentsLogout);
            UITheme.StyleNav(panelNavigation);
            foreach (Control c in panelNavigation.Controls)
                if (c is Button b) UITheme.StyleNavButton(b, b == btnScreening);
            UITheme.StyleGrid(dgvScreeningList);
            UITheme.StylePrimaryButton(btnApprove, UITheme.AccentGreen);
            UITheme.StyleSecondaryButton(btnRejectEmailNotice);
            UITheme.StyleComboBox(cmbEduFit);
            UITheme.StyleComboBox(cmbTechFit);
            UITheme.StyleComboBox(cmbExpFit);
            UITheme.StyleTextBox(txtScreeningNotes);
            UITheme.StyleTextBox(txtApplicantName);
            UITheme.StyleTextBox(txtPosition);

            SetDecisionButtonsEnabled(false);
            WireNavButtons();

            FixComboItems(cmbEduFit);
            FixComboItems(cmbTechFit);
            FixComboItems(cmbExpFit);

            btnRejectEmailNotice.Text = "❌ Reject Application";
            LoadApplicantsForScreening();
        }

        private void FixComboItems(ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.Add("Exceeds Standards");
            cmb.Items.Add("Meets Expectations");
            cmb.Items.Add("Below Standards");
        }

        private void LoadApplicantsForScreening()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        a.application_id                         AS ApplicationID,
                        ap.id                                    AS ApplicantID,
                        CONCAT(ap.first_name,' ',ap.last_name)   AS ApplicantName,
                        COALESCE(j.position, 'N/A')              AS Position,
                        a.status                                 AS Status
                    FROM applicants ap
                    INNER JOIN applications a  ON ap.id = a.applicant_id
                    LEFT  JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                    WHERE a.status = 'Under Review'
                    ORDER BY a.application_date ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvScreeningList.DataSource = null;
                dgvScreeningList.AutoGenerateColumns = true;
                dgvScreeningList.DataSource = dt;
            }
        }

        private void dgvScreeningList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvScreeningList.CurrentRow == null) return;

            var row = dgvScreeningList.CurrentRow;

            if (row.Cells["ApplicationID"].Value == null ||
                row.Cells["ApplicantID"].Value == null) return;

            _selectedApplicationId =
                Convert.ToInt32(row.Cells["ApplicationID"].Value);
            _selectedApplicantId =
                Convert.ToInt32(row.Cells["ApplicantID"].Value);

            txtApplicantName.Text =
                row.Cells["ApplicantName"].Value?.ToString() ?? "";
            txtPosition.Text =
                row.Cells["Position"].Value?.ToString() ?? "";

            RunVerificationChecks();
            SetDecisionButtonsEnabled(true);

            cmbEduFit.SelectedIndex = -1;
            cmbTechFit.SelectedIndex = -1;
            cmbExpFit.SelectedIndex = -1;
            txtScreeningNotes.Clear();
        }

        private void RunVerificationChecks()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                bool profileComplete = CheckProfileComplete(conn);
                bool hasGovId = CheckDocumentExists(conn, "Government ID");
                bool hasResume = CheckDocumentExists(conn, "Resume");
                bool hasTranscript = CheckDocumentExists(conn, "Transcript");

                checkedListBox1.SetItemChecked(0, profileComplete);
                checkedListBox1.SetItemChecked(1, hasGovId);
                checkedListBox1.SetItemChecked(2, hasResume);
                checkedListBox1.SetItemChecked(3, hasTranscript);

                int passed = (profileComplete ? 1 : 0) +
                             (hasGovId ? 1 : 0) +
                             (hasResume ? 1 : 0) +
                             (hasTranscript ? 1 : 0);

                lblVerificationStatus.Text =
                    $"📑 System Requirement Verification: {passed}/4 passed";

                lblVerificationStatus.ForeColor =
                    passed == 4 ? Color.DarkGreen : Color.OrangeRed;
            }
        }

        private bool CheckProfileComplete(MySqlConnection conn)
        {
            string q = @"
                SELECT COUNT(*) FROM applicant_profiles
                WHERE applicant_id = @id
                  AND gender    IS NOT NULL
                  AND address   IS NOT NULL AND address   <> ''
                  AND province  IS NOT NULL AND province  <> ''";
            MySqlCommand cmd = new MySqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", _selectedApplicantId);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private bool CheckDocumentExists(MySqlConnection conn, string docType)
        {
            string q = @"
                SELECT COUNT(*) FROM applicant_documents
                WHERE applicant_id = @id
                  AND LOWER(document_type) LIKE @type";
            MySqlCommand cmd = new MySqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", _selectedApplicantId);
            cmd.Parameters.AddWithValue("@type", "%" + docType.ToLower() + "%");
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (_selectedApplicationId < 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (cmbEduFit.SelectedIndex < 0 ||
                cmbTechFit.SelectedIndex < 0 ||
                cmbExpFit.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please complete all three evaluation fields before approving.",
                    "Incomplete Evaluation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbEduFit.Text == "Below Standards" ||
                cmbTechFit.Text == "Below Standards" ||
                cmbExpFit.Text == "Below Standards")
            {
                MessageBox.Show(
                    "One or more evaluation scores are Below Standards.\n" +
                    "Consider rejecting this applicant instead.",
                    "Low Score Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Approve {txtApplicantName.Text} for the interview loop?\n" +
                "Their status will be set to Shortlisted.",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            UpdateApplicationStatus(_selectedApplicationId, "Shortlisted");
            SaveScreeningNotes(_selectedApplicationId);

            MessageBox.Show(
                $"{txtApplicantName.Text} has been shortlisted successfully.\n" +
                "They will see this update in their application status.",
                "Approved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetForm();
            LoadApplicantsForScreening();
        }

        private void btnRejectEmailNotice_Click(object sender, EventArgs e)
        {
            if (_selectedApplicationId < 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (cmbEduFit.SelectedIndex < 0 ||
                cmbTechFit.SelectedIndex < 0 ||
                cmbExpFit.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please complete all three evaluation fields before rejecting.",
                    "Incomplete Evaluation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Reject {txtApplicantName.Text}'s application?\n" +
                "Their status will be set to Rejected and they will see this " +
                "update in their applicant portal.",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            UpdateApplicationStatus(_selectedApplicationId, "Rejected");
            SaveScreeningNotes(_selectedApplicationId);

            MessageBox.Show(
                $"{txtApplicantName.Text}'s application has been rejected.\n" +
                "The applicant can view this decision in their portal.",
                "Rejected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetForm();
            LoadApplicantsForScreening();
        }

        private void UpdateApplicationStatus(int applicationId, string newStatus)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateQuery = @"
                    UPDATE applications
                    SET status = @status
                    WHERE application_id = @id";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", applicationId);
                cmd.ExecuteNonQuery();

                string historyQuery = @"
                    INSERT INTO application_status_history
                        (application_id, status, changed_at)
                    VALUES
                        (@id, @status, NOW())";

                MySqlCommand histCmd = new MySqlCommand(historyQuery, conn);
                histCmd.Parameters.AddWithValue("@id", applicationId);
                histCmd.Parameters.AddWithValue("@status", newStatus);
                histCmd.ExecuteNonQuery();

                TakeSnapshotIfNeeded(conn, applicationId, newStatus);
            }
        }

        private void SaveScreeningNotes(int applicationId)
        {
            if (string.IsNullOrWhiteSpace(txtScreeningNotes.Text)) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string getApplicant = @"
                    SELECT applicant_id FROM applications
                    WHERE application_id = @id";
                MySqlCommand getCmd = new MySqlCommand(getApplicant, conn);
                getCmd.Parameters.AddWithValue("@id", applicationId);
                int applicantId = Convert.ToInt32(getCmd.ExecuteScalar());

                string noteQuery = @"
                    INSERT INTO updates
                        (applicant_id, update_message, created_at)
                    VALUES
                        (@applicantId, @msg, NOW())";

                MySqlCommand noteCmd = new MySqlCommand(noteQuery, conn);
                noteCmd.Parameters.AddWithValue("@applicantId", applicantId);
                noteCmd.Parameters.AddWithValue("@msg",
                    $"[Screening] {cmbEduFit.Text} | {cmbTechFit.Text} | " +
                    $"{cmbExpFit.Text} — {txtScreeningNotes.Text}");
                noteCmd.ExecuteNonQuery();
            }
        }

        private void TakeSnapshotIfNeeded(
            MySqlConnection conn, int applicationId, string newStatus)
        {
            var lockedStatuses = new HashSet<string>
            {
                "Shortlisted", "Interview", "Final Review", "Accepted", "Rejected"
            };
            if (!lockedStatuses.Contains(newStatus)) return;

            string checkQuery = @"
                SELECT COUNT(*) FROM application_profile_snapshots
                WHERE application_id = @id";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@id", applicationId);
            if (Convert.ToInt64(checkCmd.ExecuteScalar()) > 0) return;

            string insertQuery = @"
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
                LEFT JOIN education ed          ON a.id = ed.applicant_id
                WHERE a.id = (
                    SELECT applicant_id FROM applications
                    WHERE application_id = @appId)";

            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@appId", applicationId);
            insertCmd.ExecuteNonQuery();
        }

        private void SetDecisionButtonsEnabled(bool enabled)
        {
            btnApprove.Enabled = enabled;
            btnRejectEmailNotice.Enabled = enabled;
        }

        private void ResetForm()
        {
            txtApplicantName.Clear();
            txtPosition.Clear();
            txtScreeningNotes.Clear();
            cmbEduFit.SelectedIndex = -1;
            cmbTechFit.SelectedIndex = -1;
            cmbExpFit.SelectedIndex = -1;
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            lblVerificationStatus.Text = "📑 System Requirement Verification:";
            lblVerificationStatus.ForeColor = SystemColors.ControlText;
            _selectedApplicationId = -1;
            _selectedApplicantId = -1;
            SetDecisionButtonsEnabled(false);
        }

        private void WireNavButtons()
        {
            btnMyDocumentsDashboard.Click += (s, e) => NavigateTo(
                () => new HRDashboard { UserRole = UserRole, UserName = UserName });

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

        private void btnHiringDecision_Click(object sender, EventArgs e)
        {
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void btnJobVacanciesManagement_Click(object sender, EventArgs e)
        {
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
        }
    }
}
