using System;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project
{
    public partial class ApplicantPage1 : Form
    {
        public int ApplicantId { get; set; }

        string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public ApplicantPage1()
        {
            InitializeComponent();

            txtJobTitle.ReadOnly = true;
            txtDept.ReadOnly = true;

            dtpDataFiled.Enabled = false;

            clbApplicationSteps.Enabled = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void ApplicantPage1_Load(object sender, EventArgs e)
        {
            LoadApplication();
        }

        private void LoadApplication()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string appQuery = @"
                SELECT
                    a.application_id,
                    a.application_date,
                    a.status,
                    COALESCE(j.position,   'Not yet selected') AS position,
                    COALESCE(j.department, 'Not yet selected') AS department
                FROM applications a
                LEFT JOIN job_vacancies j      
                    ON a.vacancy_id = j.vacancy_id
                WHERE a.applicant_id = @id
                ORDER BY a.application_date DESC
                LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(appQuery, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        txtJobTitle.Text = "No application found";
                        txtDept.Text = "-";
                        lblCurrentStatus.Text = "Current Status: None";
                        lblStatusDescription.Text = "You have not applied for any position yet.";
                        return;
                    }

                    int applicationId = Convert.ToInt32(reader["application_id"]);
                    string status = reader["status"].ToString();

                    txtJobTitle.Text = reader["position"].ToString();
                    txtDept.Text = reader["department"].ToString();
                    dtpDataFiled.Value = Convert.ToDateTime(reader["application_date"]);
                    lblCurrentStatus.Text = "Current Status: " + status;

                    lblStatusDescription.Text = GetStatusDescription(status);
                    lblCurrentStatus.ForeColor = GetStatusColor(status);

                    reader.Close();

                    bool profileDone = CheckProfileCompleted(conn);
                    bool documentsDone = CheckDocumentsUploaded(conn);
                    bool hrReviewDone = CheckHrReviewDone(status);
                    bool interviewDone = CheckInterviewDone(status);

                    UpdateStepFlags(
                        conn, applicationId,
                        profileDone, documentsDone,
                        hrReviewDone, interviewDone);

                    clbApplicationSteps.SetItemChecked(0, profileDone);
                    clbApplicationSteps.SetItemChecked(1, documentsDone);
                    clbApplicationSteps.SetItemChecked(2, hrReviewDone);
                    clbApplicationSteps.SetItemChecked(3, interviewDone);

                    ColorStepItem(0, profileDone);
                    ColorStepItem(1, documentsDone);
                    ColorStepItem(2, hrReviewDone);
                    ColorStepItem(3, interviewDone);

                    ApplyApplicationLock(status);
                }
            }
        }

        private bool CheckProfileCompleted(MySqlConnection conn)
        {
            string query = @"
                SELECT COUNT(*) FROM applicant_profiles
                WHERE applicant_id = @id
                  AND gender        IS NOT NULL
                  AND address       IS NOT NULL
                  AND address       <> ''
                  AND province      IS NOT NULL
                  AND province      <> ''";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ApplicantId);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private bool CheckDocumentsUploaded(MySqlConnection conn)
        {
            string query = @"
                SELECT COUNT(*) FROM applicant_documents
                WHERE applicant_id = @id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ApplicantId);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private bool CheckHrReviewDone(string status)
        {
            return status == "Under Review" ||
                   status == "Shortlisted" ||
                   status == "Interview" ||
                   status == "Final Review" ||
                   status == "Accepted" ||
                   status == "Rejected";
        }

        private bool CheckInterviewDone(string status)
        {
            return status == "Interview" ||
                   status == "Final Review" ||
                   status == "Accepted" ||
                   status == "Rejected";
        }

        private void UpdateStepFlags(
            MySqlConnection conn,
            int applicationId,
            bool profileDone,
            bool documentsDone,
            bool hrReviewDone,
            bool interviewDone)
        {
            string query = @"
            UPDATE applications
            SET
               profile_completed    = @p,
               documents_uploaded   = @d,
               hr_review            = @h,
               technical_interview  = @t
            WHERE application_id = @id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@p", profileDone ? 1 : 0);
            cmd.Parameters.AddWithValue("@d", documentsDone ? 1 : 0);
            cmd.Parameters.AddWithValue("@h", hrReviewDone ? 1 : 0);
            cmd.Parameters.AddWithValue("@t", interviewDone ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", applicationId);
            cmd.ExecuteNonQuery();
        }


        private void ColorStepItem(int index, bool done)
        {
            string[] baseNames = new string[]
            {
                "Profile Completed",
                "Mandatory Documents Uploaded",
                "HR Preliminary Review",
                "Technical Panel Interview"
            };

            string prefix = done ? "✓ " : "○ ";
            clbApplicationSteps.Items[index] = prefix + baseNames[index];
        }

        private void ApplyApplicationLock(string status)
        {
            bool isLocked = status == "Under Review" ||
                            status == "Shortlisted" ||
                            status == "Interview" ||
                            status == "Final Review" ||
                            status == "Accepted" ||
                            status == "Rejected";

            if (isLocked)
            {
                btnMyDocumentsDocuments.Enabled = false;
                btnMyDocumentsDocuments.Text = "Documents (Locked)";
                lblCurrentStatus.ForeColor = Color.OrangeRed;
                lblStatusDescription.Text =
                    GetStatusDescription(status) +
                    "\nDocuments are locked while under review.";
            }
            else
            {
                btnMyDocumentsDocuments.Enabled = true;
                btnMyDocumentsDocuments.Text = "Documents";
            }
        }

        private string GetStatusDescription(string status)
        {
            switch (status)
            {
                case "Draft": return "You have not submitted an application yet.";
                case "Submitted": return "Application submitted successfully.";
                case "Under Review": return "HR is reviewing your application.";
                case "Shortlisted": return "You have been shortlisted.";
                case "Interview": return "Interview schedule will be sent.";
                case "Final Review": return "Final evaluation in progress.";
                case "Accepted": return "Congratulations! You have been accepted.";
                case "Rejected": return "Application was not selected.";
                case "Withdrawn": return "You have withdrawn your application.";
                default: return "Application in progress.";
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Draft": return Color.Gray;
                case "Submitted": return Color.SteelBlue;
                case "Under Review": return Color.Orange;
                case "Shortlisted": return Color.DodgerBlue;
                case "Interview": return Color.MediumPurple;
                case "Final Review": return Color.DarkOrange;
                case "Accepted": return Color.Green;
                case "Rejected": return Color.Red;
                case "Withdrawn": return Color.DimGray;
                default: return Color.Black;
            }
        }

        private void btnMyDocumentsMyProfile_Click(object sender, EventArgs e)
        {
            profilepage profile = new profilepage(ApplicantId);
            profile.FormClosed += (s, args) => this.Show();
            this.Hide();
            profile.Show();
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ApplicantId = ApplicantId;
            dashboard.FormClosed += (s, args) => this.Show();
            this.Hide();
            dashboard.Show();
        }

        private void btnMyDocumentsDashboard_Click_1(object sender, EventArgs e)
        {
            btnMyDocumentsDashboard_Click(sender, e);
        }

        private void btnMyDocumentsJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacancies jobs = new JobVacancies();
            jobs.applicantId = ApplicantId;
            jobs.FormClosed += (s, args) => this.Show();
            this.Hide();
            jobs.Show();
        }

        private void btnMyDocumentsDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();
            doc.ApplicantId = ApplicantId;
            doc.FormClosed += (s, args) => this.Show();
            this.Hide();
            doc.Show();
        }

        private void btnMyDocumentsStatusTracking_Click(object sender, EventArgs e)
        {
            StatusTracking st = new StatusTracking(ApplicantId);
            st.FormClosed += (s, args) => this.Show();
            this.Hide();
            st.Show();
        }

        private void btnMyDocumentsMyApplication_Click(object sender, EventArgs e)
        {
        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void grpPositionInfo_Enter(object sender, EventArgs e) { }
        private void panelMyDocumentsHeader_Paint(
            object sender, System.Windows.Forms.PaintEventArgs e)
        { }
    }
}
