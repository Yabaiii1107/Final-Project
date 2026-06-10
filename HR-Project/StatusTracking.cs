using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project
{
    public partial class StatusTracking : Form
    {
        public int ApplicantId { get; set; }

        private string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        private static readonly Dictionary<string, int> StatusProgress =
            new Dictionary<string, int>
            {
                { "Submitted",    10 },
                { "Under Review", 30 },
                { "Shortlisted",  50 },
                { "Interview",    65 },
                { "Final Review", 80 },
                { "Accepted",    100 },
                { "Rejected",      0 },
            };

        private static readonly List<string> Pipeline = new List<string>
        {
            "Submitted",
            "Under Review",   
            "Shortlisted",    
            "Interview",      
            "Final Review",   
            "Accepted",       
        };

        public StatusTracking()
        {
            InitializeComponent();
        }

        public StatusTracking(int applicantId)
        {
            InitializeComponent();
            ApplicantId = applicantId;
        }

        private void StatusTracking_Load(object sender, EventArgs e)
        {
            LoadApplicantInfo();
            LoadStatusHistory();
            WireNavButtons();
        }

        private void LoadApplicantInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        ap.first_name,
                        ap.last_name,
                        ap.id,
                        a.status
                    FROM applicants ap
                    LEFT JOIN applications a
                        ON ap.id = a.applicant_id
                    WHERE ap.id = @id
                    ORDER BY a.application_date DESC
                    LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string fullName =
                            reader["first_name"] + " " + reader["last_name"];

                        lblName.Text = fullName;
                        lblID.Text = reader["id"].ToString();

                        string status = reader["status"]?.ToString() ?? "Submitted";
                        lblCurrentStatus.Text = status;

                        lblCurrentStatus.ForeColor = GetStatusColor(status);

                        progressBarStatus.Value =
                            StatusProgress.ContainsKey(status)
                            ? StatusProgress[status]
                            : 0;

                        UpdateProgressLabels(status);
                    }
                    else
                    {
                        lblName.Text = "No data found";
                        lblID.Text = ApplicantId.ToString();
                        lblCurrentStatus.Text = "N/A";
                    }
                }
            }
        }

        private void LoadStatusHistory()
        {
            dgvStatusHistory.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        h.changed_at,
                        h.status
                    FROM application_status_history h
                    INNER JOIN applications a
                        ON h.application_id = a.application_id
                    WHERE a.applicant_id = @id
                    ORDER BY h.changed_at ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string date = Convert.ToDateTime(reader["changed_at"])
                                            .ToString("MM/dd/yyyy hh:mm tt");
                        string status = reader["status"].ToString();
                        string remark = GetStatusRemark(status);

                        dgvStatusHistory.Rows.Add(date, status, remark);
                    }
                }
            }
        }

        private void UpdateProgressLabels(string currentStatus)
        {
            Label[] stepLabels = new Label[]
            {
                lblSubmitted,
                lblHrScreening,
                lblInitialInterview,
                lblFinalInterview,
                lblJobOffer,
                lblHired
            };

            int reachedIndex = Pipeline.IndexOf(currentStatus);

            bool isRejected = currentStatus == "Rejected";

            for (int i = 0; i < stepLabels.Length; i++)
            {
                if (isRejected)
                {
                    if (i == 0)
                    {
                        stepLabels[i].ForeColor = Color.Green;
                        stepLabels[i].Text = GetStepText(i, done: true);
                    }
                    else
                    {
                        stepLabels[i].ForeColor = Color.Gray;
                        stepLabels[i].Text = GetStepText(i, done: false);
                    }
                }
                else if (i <= reachedIndex)
                {
                    stepLabels[i].ForeColor = Color.Green;
                    stepLabels[i].Text = GetStepText(i, done: true);
                }
                else
                {
                    stepLabels[i].ForeColor = Color.Gray;
                    stepLabels[i].Text = GetStepText(i, done: false);
                }
            }
        }

        private string GetStepText(int index, bool done)
        {
            string[] names = new string[]
            {
                "Submitted",
                "HR Screening",
                "Initial Interview",
                "Final Interview",
                "Job Offer",
                "Hired"
            };
            string icon = done ? "✓" : "⏳";
            return $" {icon} {names[index]} ";
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Submitted": return Color.SteelBlue;
                case "Under Review": return Color.Orange;
                case "Shortlisted": return Color.DodgerBlue;
                case "Interview": return Color.MediumPurple;
                case "Final Review": return Color.DarkOrange;
                case "Accepted": return Color.Green;
                case "Rejected": return Color.Red;
                default: return Color.Black;
            }
        }

        private string GetStatusRemark(string status)
        {
            switch (status)
            {
                case "Submitted": return "Application received.";
                case "Under Review": return "HR is reviewing your application.";
                case "Shortlisted": return "You have been shortlisted.";
                case "Interview": return "Interview schedule will be sent.";
                case "Final Review": return "Final evaluation in progress.";
                case "Accepted": return "Congratulations! You are hired.";
                case "Rejected": return "Application was not selected.";
                default: return "Status updated.";
            }
        }

        private void WireNavButtons()
        {
            btnProfilePageDashboard.Click += (s, e) => NavigateTo(() =>
            {
                Dashboard db = new Dashboard();
                db.ApplicantId = ApplicantId;
                return db;
            });

            btnProfilePageMyProfile.Click += (s, e) => NavigateTo(() =>
            new profilepage(ApplicantId));

            btnProfilePageJobVacancies.Click += (s, e) => NavigateTo(() =>
            {
                JobVacancies jobs = new JobVacancies();
                jobs.applicantId = ApplicantId;
                return jobs;
            });

            btnProfilePageMyApplication.Click += (s, e) => NavigateTo(() =>
            {
                ApplicantPage1 app = new ApplicantPage1();
                app.ApplicantId = ApplicantId;
                return app;
            });

            btnProfilePageDocuments.Click += (s, e) => NavigateTo(() =>
            {
                DocumentPage doc = new DocumentPage();
                doc.ApplicantId = ApplicantId;
                return doc;
            });

            btnProfilePageStatusTracking.Enabled = false;
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) => this.Show();
            this.Hide();
            next.Show();
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

        private void lblJobOffer_Click(object sender, EventArgs e) { }
        private void lblAccepted_Click(object sender, EventArgs e) { }
        private void progressBarStatus_Click(object sender, EventArgs e) { }
    }
}
