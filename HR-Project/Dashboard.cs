using System;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using System.IO;

namespace HR_Project
{
    public partial class Dashboard : Form
    {
        public int ApplicantId { get; set; }

        public int SelectedApplicationId { get; set; }

        string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        private string _applicantName;
        public string ApplicantName
        {
            get { return _applicantName; }
            set { _applicantName = value; }
        }

        public Dashboard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApplicantTheme.Apply(this, "btnDashboard");
            ApplyStatCardAccents();

            LoadApplicationSelector();
            LoadApplicantInfo();
            LoadApplicationStatus();
            LoadAppliedPosition();
            LoadDocumentStatusGrid();
            LoadApplicationProgressGrid();
            LoadInterviewSchedule();
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            LoadApplicantInfo();
            LoadDocumentStatusGrid();
            LoadApplicationProgressGrid();
            LoadApplicationStatus();
            LoadInterviewSchedule();
        }

        private void ApplyStatCardAccents()
        {
            PaintAccent(panelCardStatus, HR_Project.HR_System.UITheme.AccentBlue);
            PaintAccent(panelAppliedPosition0, HR_Project.HR_System.UITheme.AccentGreen);
            PaintAccent(panelMissingDocuments, Color.FromArgb(255, 159, 10));
        }

        private void PaintAccent(Panel panel, Color color)
        {
            panel.Paint += (s, e) =>
            {
                using (var brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush,
                        new Rectangle(0, 0, 4, panel.Height));
            };
        }

        private void LoadApplicantInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT a.first_name, a.last_name, ap.profile_picture
                FROM applicants a
                LEFT JOIN applicant_profiles ap ON a.id = ap.applicant_id
                WHERE a.id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString();

                        lblApplicantFirstName.Text = firstName;
                        lblApplicantLastName.Text = lastName;
                        lblApplicantName1.Text = firstName + " " + lastName;

                        if (reader["profile_picture"] != System.DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["profile_picture"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                                picBoxDashboardpfp.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private void LoadApplicationStatus()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT status FROM applications
                WHERE application_id = @appId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);
                object result = cmd.ExecuteScalar();

                string status = result?.ToString() ?? "—";

                if (HasAcceptedApplication() && status != "Accepted")
                {
                    status = "Closed";
                }

                lblCurrentStatus.Text = status;
                lblCurrentStatus.ForeColor = GetStatusColor(status);
            }
        }

        private void LoadAppliedPosition()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT j.position
                FROM applications a
                INNER JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE a.application_id = @appId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);
                object result = cmd.ExecuteScalar();
                lblPosition.Text = result?.ToString() ?? "No Application Yet";
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
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }


        private void LoadInterviewSchedule()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT interview_date, interview_time,
                           interview_type, location_link
                    FROM interviews
                    WHERE application_id = @appId
                    LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader["interview_date"]);
                            TimeSpan time = (TimeSpan)reader["interview_time"];
                            string mode = reader["interview_type"].ToString();
                            string location = reader["location_link"].ToString();

                            lblInterviewSchedule.Text =
                                $"{date:MMM dd, yyyy}\n{DateTime.Today.Add(time):hh:mm tt}  [{mode}]";
                            lblInterviewSchedule.ForeColor =
                                HR_Project.HR_System.UITheme.AccentBlue;
                        }
                        else
                        {
                            lblInterviewSchedule.Text = "No interview scheduled.";
                            lblInterviewSchedule.ForeColor =
                                HR_Project.HR_System.UITheme.TextMuted;
                        }
                    }
                }
            }
            catch (MySqlConnector.MySqlException)
            {
                lblInterviewSchedule.Text = "No interview scheduled.";
                lblInterviewSchedule.ForeColor = HR_Project.HR_System.UITheme.TextMuted;
            }
        }

        private void LoadDocumentStatusGrid()
        {
            dgvDocumentStatus.Rows.Clear();
            HR_Project.HR_System.UITheme.StyleGrid(dgvDocumentStatus);

            string[] docTypes = new[]
            {
                "Resume/CV", "Government ID", "Transcript", "Certificates"
            };

            bool hasResume = false, hasGovID = false,
                 hasTranscript = false, hasCerts = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT document_type FROM applicant_documents
                    WHERE applicant_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dt = reader["document_type"].ToString().Trim();
                        if (dt == "Resume/CV") hasResume = true;
                        if (dt == "Government ID") hasGovID = true;
                        if (dt == "Transcript") hasTranscript = true;
                        if (dt == "Certificates") hasCerts = true;
                    }
                }
            }

            bool[] found = { hasResume, hasGovID, hasTranscript, hasCerts };
            int missing = 0;

            for (int i = 0; i < docTypes.Length; i++)
            {
                string statusText = found[i] ? "✔ Submitted" : "✘ Missing";
                int rowIdx = dgvDocumentStatus.Rows.Add(docTypes[i], statusText);
                dgvDocumentStatus.Rows[rowIdx].Cells["colDocStatus"].Style.ForeColor =
                    found[i] ? Color.Green : Color.Red;
                if (!found[i]) missing++;
            }

            lblMissDocu.Text = missing.ToString();
        }

        private void LoadApplicationProgressGrid()
        {
            dgvApplicationProgress.Rows.Clear();
            HR_Project.HR_System.UITheme.StyleGrid(dgvApplicationProgress);

            string currentStatus = "";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT status
                FROM applications
                WHERE application_id = @appId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);

                currentStatus = cmd.ExecuteScalar()?.ToString() ?? "";

                if (HasAcceptedApplication() &&
                    currentStatus != "Accepted" &&
                    currentStatus != "Rejected" &&
                    currentStatus != "Withdrawn")
                {
                    currentStatus = "Closed";
                }
            }

            string[] steps = new[]
            {
                "Submitted",
                "Under Review",
                "Shortlisted",
                "For Interview",
                "For Assessment",
                "For Final Review",
                "Accepted"
            };

            if (currentStatus == "Interview") currentStatus = "For Interview";
            if (currentStatus == "Final Review") currentStatus = "For Final Review";

            int reachedIndex = Array.IndexOf(steps, currentStatus);
            bool isRejected = currentStatus == "Rejected";
            bool isWithdrawn = currentStatus == "Withdrawn";

            for (int i = 0; i < steps.Length; i++)
            {
                bool done = !isRejected && !isWithdrawn && i <= reachedIndex;
                string stepStatus = done ? "✓ Done" : "⏳ Pending";
                int rowIdx = dgvApplicationProgress.Rows.Add(steps[i], stepStatus);
                dgvApplicationProgress.Rows[rowIdx].Cells["colStepStatus"].Style.ForeColor =
                    done ? Color.Green : Color.Gray;
            }

            if (isRejected)
            {
                int rowIdx = dgvApplicationProgress.Rows.Add("Rejected", "✘ Not Selected");
                dgvApplicationProgress.Rows[rowIdx].Cells["colStepStatus"].Style.ForeColor
                    = Color.Red;
            }
            else if (isWithdrawn)
            {
                int rowIdx = dgvApplicationProgress.Rows.Add("Withdrawn", "↩ Withdrawn");
                dgvApplicationProgress.Rows[rowIdx].Cells["colStepStatus"].Style.ForeColor
                    = Color.DimGray;
            }
            else if (currentStatus == "Closed")
            {
                int rowIdx = dgvApplicationProgress.Rows.Add(
                    "Closed",
                    "✓ Closed (Another Application Accepted)");

                dgvApplicationProgress.Rows[rowIdx]
                    .Cells["colStepStatus"]
                    .Style.ForeColor = Color.DarkGray;
            }
        }

        private void LoadApplicationSelector()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT a.application_id, 
                       COALESCE(j.position, 'No Position') AS position,
                       a.application_date,
                       a.status
                FROM applications a
                LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE a.applicant_id = @id
                ORDER BY a.application_date DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                cmbApplicationSelector.Items.Clear();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int appId = Convert.ToInt32(reader["application_id"]);
                        string status = reader["status"].ToString();

                        bool applicantHasAccepted = HasAcceptedApplication();

                        if (applicantHasAccepted && status != "Accepted")
                        {
                            status = "Closed";
                        }

                        string label = $"{reader["position"]} — {status} " +
                                       $"({Convert.ToDateTime(reader["application_date"]):MMM dd, yyyy})";

                        cmbApplicationSelector.Items.Add(new ApplicationEntry(appId, label));
                    }
                }

                if (cmbApplicationSelector.Items.Count > 0)
                {
                    cmbApplicationSelector.SelectedIndex = 0;
                    SelectedApplicationId =
                        ((ApplicationEntry)cmbApplicationSelector.SelectedItem).ApplicationId;
                }
            }
        }

        public class ApplicationEntry
        {
            public int ApplicationId { get; }
            private string _label;
            public ApplicationEntry(int id, string label) { ApplicationId = id; _label = label; }
            public override string ToString() => _label;
        }

        private void cmbApplicationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbApplicationSelector.SelectedItem is ApplicationEntry entry)
            {
                SelectedApplicationId = entry.ApplicationId;

                LoadApplicationStatus();
                LoadAppliedPosition();
                LoadDocumentStatusGrid();
                LoadApplicationProgressGrid();
                LoadInterviewSchedule();
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Submitted": return Color.SteelBlue;
                case "Under Review": return Color.Orange;
                case "Shortlisted": return Color.DodgerBlue;
                case "Interview":
                case "For Interview": return Color.MediumPurple;
                case "For Assessment": return Color.Teal;
                case "Final Review":
                case "For Final Review": return Color.DarkOrange;
                case "Accepted": return Color.Green;
                case "Rejected": return Color.Red;
                case "Withdrawn": return Color.DimGray;
                case "Closed": return Color.DarkGray;
                default: return Color.FromArgb(10, 132, 255);
            }
        }


        private void btnDashboard_Click(object sender, EventArgs e) { }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            profilepage profile = new profilepage(ApplicantId);
            profile.SelectedApplicationId = SelectedApplicationId;
            profile.FormClosed += (s, args) => this.Show();
            this.Hide();                              
            profile.Show();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacancies jobs = new JobVacancies();

            jobs.applicantId = ApplicantId;

            jobs.SelectedApplicationId = SelectedApplicationId;

            jobs.FormClosed += (s, args) => this.Show();
            this.Hide();
            jobs.Show();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            ApplicantPage1 app = new ApplicantPage1();
            app.ApplicantId = ApplicantId;
            app.SelectedApplicationId = SelectedApplicationId;
            app.FormClosed += (s, args) => this.Show();
            this.Hide();
            app.Show();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();
            doc.ApplicantId = ApplicantId;
            doc.SelectedApplicationId = SelectedApplicationId;
            doc.FormClosed += (s, args) => this.Show();
            this.Hide();
            doc.Show();
        }

        private void btnStatusTracking_Click(object sender, EventArgs e)
        {
            StatusTracking st = new StatusTracking(ApplicantId, SelectedApplicationId);
            st.FormClosed += (s, args) => this.Show();
            this.Hide();
            st.Show();
        }

        private void btnDashboardClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure you want to logout?", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void lblApplicantName1_Click(object sender, EventArgs e) { }
    }
}
