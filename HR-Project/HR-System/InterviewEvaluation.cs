using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project.HR_System
{
    public partial class InterviewEvaluation : Form
    {
        private string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        // Tracks the currently selected applicant from the list
        private int _selectedApplicationId = -1;
        private int _selectedApplicantId = -1;

        public InterviewEvaluation()
        {
            InitializeComponent();
        }

        private void InterviewEvalutaion_Load(object sender, EventArgs e)
        {
            SetEvaluationControlsEnabled(false);
            LoadInterviewApplicants();
            WireNavButtons();
            WireScoreEvents();

            btnInterviews.Enabled = false; // current page
        }

        private void LoadInterviewApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        a.application_id                        AS ApplicationID,
                        ap.id                                   AS ApplicantID,
                        CONCAT(ap.first_name,' ',ap.last_name)  AS ApplicantName,
                        COALESCE(j.position, 'N/A')             AS Position,
                        COALESCE(i.interviewer, 'TBA')          AS Interviewer,
                        a.status                                AS Status
                    FROM applicants ap
                    INNER JOIN applications a   ON ap.id = a.applicant_id
                    LEFT  JOIN job_vacancies j  ON a.vacancy_id = j.vacancy_id
                    LEFT  JOIN interviews i     ON a.application_id = i.application_id
                    WHERE a.status = 'Interview'
                    ORDER BY a.application_date ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvInterviewList.DataSource = null;
                dgvInterviewList.AutoGenerateColumns = true;
                dgvInterviewList.DataSource = dt;
            }
        }

        private void dgvInterviewList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInterviewList.CurrentRow == null) return;

            var row = dgvInterviewList.CurrentRow;

            if (row.Cells["ApplicationID"].Value == null ||
                row.Cells["ApplicantID"].Value == null) return;

            _selectedApplicationId = Convert.ToInt32(row.Cells["ApplicationID"].Value);
            _selectedApplicantId = Convert.ToInt32(row.Cells["ApplicantID"].Value);

            txtApplicantName.Text = row.Cells["ApplicantName"].Value?.ToString() ?? "";
            txtPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";
            txtInterviewer.Text = row.Cells["Interviewer"].Value?.ToString() ?? "TBA";

            numTechScore.Value = 1;
            numCommScore.Value = 1;
            numProblemScore.Value = 1;
            rbPass.Checked = false;
            rbFail.Checked = false;
            txtRemarks.Clear();

            SetEvaluationControlsEnabled(true);
            UpdateAutoRemarks();
        }

        private void WireScoreEvents()
        {
            numTechScore.ValueChanged += (s, e) => UpdateAutoRemarks();
            numCommScore.ValueChanged += (s, e) => UpdateAutoRemarks();
            numProblemScore.ValueChanged += (s, e) => UpdateAutoRemarks();
        }

        private void UpdateAutoRemarks()
        {
            int tech = (int)numTechScore.Value;
            int comm = (int)numCommScore.Value;
            int problem = (int)numProblemScore.Value;
            double avg = (tech + comm + problem) / 3.0;

            string techRemark = GetScoreLabel(tech);
            string commRemark = GetScoreLabel(comm);
            string problemRemark = GetScoreLabel(problem);

            txtRemarks.Text =
                $"Technical Skill: {tech}/5 — {techRemark}\r\n" +
                $"Communication:   {comm}/5 — {commRemark}\r\n" +
                $"Problem Solving: {problem}/5 — {problemRemark}\r\n" +
                $"Average Score:   {avg:F1}/5";
        }

        private string GetScoreLabel(int score)
        {
            switch (score)
            {
                case 5: return "Excellent";
                case 4: return "Good";
                case 3: return "Average";
                case 2: return "Below Average";
                default: return "Poor";
            }
        }

        private void btnSubmitEvaluation_Click(object sender, EventArgs e)
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

            if (!rbPass.Checked && !rbFail.Checked)
            {
                MessageBox.Show(
                    "Please select Pass or Fail before submitting.",
                    "Incomplete Evaluation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbRecommendation.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a Panel Recommendation before submitting.",
                    "Incomplete Evaluation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (rbFail.Checked && cmbRecommendation.Text == "HIre")
            {
                MessageBox.Show(
                    "Cannot recommend 'Hire' for a failed applicant.\n" +
                    "Please change the recommendation or the pass/fail result.",
                    "Contradictory Evaluation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string newStatus = rbPass.Checked ? "Final Review" : "Rejected";
            string resultText = rbPass.Checked ? "PASSED" : "FAILED";

            DialogResult confirm = MessageBox.Show(
                $"Submit evaluation for {txtApplicantName.Text}?\n\n" +
                $"Result: {resultText}\n" +
                $"Next Status: {newStatus}\n\n" +
                "This cannot be undone.",
                "Confirm Evaluation Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                SaveEvaluation(newStatus);

                MessageBox.Show(
                    $"Evaluation submitted for {txtApplicantName.Text}.\n" +
                    $"Status updated to: {newStatus}",
                    "Evaluation Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ResetForm();
                LoadInterviewApplicants();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while saving the evaluation:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveEvaluation(string newStatus)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateQuery = @"
                    UPDATE applications
                    SET status = @status
                    WHERE application_id = @id";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@status", newStatus);
                updateCmd.Parameters.AddWithValue("@id", _selectedApplicationId);
                updateCmd.ExecuteNonQuery();

                string historyQuery = @"
                    INSERT INTO application_status_history
                        (application_id, status, changed_at)
                    VALUES
                        (@id, @status, NOW())";

                MySqlCommand histCmd = new MySqlCommand(historyQuery, conn);
                histCmd.Parameters.AddWithValue("@id", _selectedApplicationId);
                histCmd.Parameters.AddWithValue("@status", newStatus);
                histCmd.ExecuteNonQuery();

                string resultText = rbPass.Checked ? "PASSED" : "FAILED";
                string noteMessage =
                    $"[Interview Evaluation] {resultText} | " +
                    $"Tech: {numTechScore.Value}/5 | " +
                    $"Comm: {numCommScore.Value}/5 | " +
                    $"Problem: {numProblemScore.Value}/5 | " +
                    $"Recommendation: {cmbRecommendation.Text}";

                string noteQuery = @"
                    INSERT INTO updates
                        (applicant_id, update_message, created_at)
                    VALUES
                        (@applicantId, @msg, NOW())";

                MySqlCommand noteCmd = new MySqlCommand(noteQuery, conn);
                noteCmd.Parameters.AddWithValue("@applicantId", _selectedApplicantId);
                noteCmd.Parameters.AddWithValue("@msg", noteMessage);
                noteCmd.ExecuteNonQuery();

                // 4. Take profile snapshot if moving to Final Review
                if (newStatus == "Final Review" || newStatus == "Rejected")
                    TakeSnapshotIfNeeded(conn, _selectedApplicationId);
            }
        }

        private void TakeSnapshotIfNeeded(MySqlConnection conn, int applicationId)
        {
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

        private void SetEvaluationControlsEnabled(bool enabled)
        {
            numTechScore.Enabled = enabled;
            numCommScore.Enabled = enabled;
            numProblemScore.Enabled = enabled;
            rbPass.Enabled = enabled;
            rbFail.Enabled = enabled;
            cmbRecommendation.Enabled = enabled;
            btnSubmitEvaluation.Enabled = enabled;
        }

        private void ResetForm()
        {
            txtApplicantName.Clear();
            txtPosition.Clear();
            txtInterviewer.Clear();
            txtRemarks.Clear();
            numTechScore.Value = 1;
            numCommScore.Value = 1;
            numProblemScore.Value = 1;
            rbPass.Checked = false;
            rbFail.Checked = false;
            cmbRecommendation.SelectedIndex = -1;
            _selectedApplicationId = -1;
            _selectedApplicantId = -1;
            SetEvaluationControlsEnabled(false);
        }

        private void WireNavButtons()
        {
            btnMyDocumentsDashboard.Click += (s, e) => NavigateTo(
                () => new HRDashboard());

            btnApplicants.Click += (s, e) => NavigateTo(
                () => new HRApplicants());

            btnJobVacanciesManagement.Click += (s, e) => NavigateTo(
                () => new JobVacancyManagement());

            btnScreening.Click += (s, e) => NavigateTo(
                () => new Screening());

            btnMyDocumentsLogout.Click += (s, e) =>
            {
                if (MessageBox.Show(
                        "Are you sure you want to logout?",
                        "Logout",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Login().Show();
                    this.Hide();
                }
            };

            btnProfilePageClose.Click += (s, e) => Application.Exit();
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) => this.Show();
            this.Hide();
            next.Show();
        }
    }
}
