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
using System.IO;

namespace HR_Project
{
    public partial class Dashboard : Form
    {
        public int ApplicantId { get; set; }

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        private string _applicantName;

        public string ApplicantName
        {
            get { return _applicantName; }
            set
            {
                _applicantName = value;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
            this.Text = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void LoadAppliedPosition()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT j.position
                FROM applications a
                INNER JOIN job_vacancies j
                    ON a.vacancy_id = j.vacancy_id
                WHERE a.applicant_id = @id
                ORDER BY application_id DESC
                LIMIT 1";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ApplicantId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    lblPosition.Text =
                        result.ToString();
                }
                else
                {
                    lblPosition.Text =
                        "No Application Yet";
                }
            }
        }

        private void LoadApplicantInfo()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = 
                @"SELECT
                    a.first_name,
                    a.last_name,
                    ap.profile_picture
                FROM applicants a
                LEFT JOIN applicant_profiles ap
                    ON a.id = ap.applicant_id
                WHERE a.id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ApplicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblApplicantFirstName.Text =
                        reader["first_name"].ToString();

                    lblApplicantLastName.Text =
                        reader["last_name"].ToString();

                    if (reader["profile_picture"] != DBNull.Value)
                    {
                        byte[] imageBytes =
                            (byte[])reader["profile_picture"];

                        using (MemoryStream ms =
                            new MemoryStream(imageBytes))
                        {
                            picBoxDashboardpfp.Image =
                                Image.FromStream(ms);
                        }
                    }
                }

                reader.Close();
            }
        }

        private void LoadApplicationStatus()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT status
                FROM applications
                WHERE applicant_id=@id
                ORDER BY application_id DESC
                LIMIT 1";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ApplicantId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    lblCurrentStatus.Text =
                        result.ToString();
                }
            }
        }

        private void LoadDocumentStatus()
        {
            int submitted = 0;

            bool hasResume = false;
            bool hasGovID = false;
            bool hasTranscript = false;
            bool hasCertificates = false;

            string connectionString =
                "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT document_type
                  FROM applicant_documents
                  WHERE applicant_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ApplicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    string docType =
                        reader["document_type"].ToString();

                    if (docType.Trim() == "Resume/CV")
                        hasResume = true;

                    if (docType.Trim() == "Government ID")
                        hasGovID = true;

                    if (docType.Trim() == "Transcript")
                        hasTranscript = true;

                    if (docType.Trim() == "Certificates")
                        hasCertificates = true;
                }
            }

            if (hasResume) submitted++;
            if (hasGovID) submitted++;
            if (hasTranscript) submitted++;
            if (hasCertificates) submitted++;

            int missing = 4 - submitted;

            lblMissDocu.Text =
                missing + " Documents";

            if (hasResume)
            {
                lblResumeStatus.Text = "✔ Submitted";
                lblResumeStatus.ForeColor = Color.Green;
            }
            else
            {
                lblResumeStatus.Text = "✘ Missing";
                lblResumeStatus.ForeColor = Color.Red;
            }

            // Government ID
            if (hasGovID)
            {
                lblGovernmentIDStatus.Text = "✔ Submitted";
                lblGovernmentIDStatus.ForeColor = Color.Green;
            }
            else
            {
                lblGovernmentIDStatus.Text = "✘ Missing";
                lblGovernmentIDStatus.ForeColor = Color.Red;
            }

            // Transcript
            if (hasTranscript)
            {
                lblTranscriptStatus.Text = "✔ Submitted";
                lblTranscriptStatus.ForeColor = Color.Green;
            }
            else
            {
                lblTranscriptStatus.Text = "✘ Missing";
                lblTranscriptStatus.ForeColor = Color.Red;
            }

            // Certificates
            if (hasCertificates)
            {
                lblCertificatesStatus.Text = "✔ Submitted";
                lblCertificatesStatus.ForeColor = Color.Green;
            }
            else
            {
                lblCertificatesStatus.Text = "✘ Missing";
                lblCertificatesStatus.ForeColor = Color.Red;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatusTracking_Click(object sender, EventArgs e)
        {
            StatusTracking st = new StatusTracking(ApplicantId);
            st.Show();
            this.Hide();

            panelNavigation.BringToFront();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblMissingDocuments_Click(object sender, EventArgs e)
        {

        }

        private void lblDraft_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationProgress_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxInterviewSchedule_Enter(object sender, EventArgs e)
        {

        }

        private void lblDate1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDocumentsUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lblTranscript_Click(object sender, EventArgs e)
        {

        }

        private void lblDocuStatus2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboardClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblApplicantName1.Text = ApplicantName;

            LoadApplicantInfo();
            LoadDocumentStatus();
            LoadAppliedPosition();
            LoadApplicationStatus();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();

            profilepage profile =
                Application.OpenForms["profilepage"]
                as profilepage;

            if (profile == null)
            {
                profile = new profilepage(ApplicantId);
            }

            profile.Show();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacancies jobs = new JobVacancies();

            jobs.applicantId = ApplicantId;

            jobs.Show();
            this.Hide();

            panelNavigation.BringToFront();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            ApplicantPage1 app =
                new ApplicantPage1();

            app.ApplicantId = ApplicantId;

            app.Show();

            this.Hide();

            panelNavigation.BringToFront();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();

            doc.ApplicantId = ApplicantId;

            doc.Show();
            this.Hide();

            panelNavigation.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void lblApplicantName1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            LoadDocumentStatus();
        }
    }
}
