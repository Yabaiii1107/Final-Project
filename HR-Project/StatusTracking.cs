using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using HR_Project.HR_System;

namespace HR_Project
{
    public partial class StatusTracking : Form
    {
        public int ApplicantId { get; set; }

        public int SelectedApplicationId { get; set; }

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

        public StatusTracking(int applicantId, int selectedApplicationId)
        {
            InitializeComponent();
            ApplicantId = applicantId;
            SelectedApplicationId = selectedApplicationId;
            ApplicantTheme.Apply(this, "btnProfilePageStatusTracking");
        }

        private void StatusTracking_Load(object sender, EventArgs e)
        {
            ApplicantTheme.Apply(this, "btnProfilePageStatusTracking");
            progressBarStatus.ForeColor = UITheme.AccentGreen;
            this.BackColor = UITheme.BgPage;

            LoadApplicantInfo();
            LoadStatusHistory();
            WireNavButtons();

            UITheme.StyleActiveNavigationButton(btnProfilePageStatusTracking);
            btnProfilePageStatusTracking.Enabled = true;
        }

        private void LoadApplicantInfo()
        {
            if (SelectedApplicationId == 0)
            {
                lblCurrentStatus.Text = "No application selected.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT ap.first_name, ap.last_name, ap.id, a.status
                FROM applicants ap
                LEFT JOIN applications a ON a.application_id = @appId
                WHERE ap.id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);
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
            if (SelectedApplicationId == 0)
            {
                lblCurrentStatus.Text = "No application selected.";
                return;
            }

            dgvStatusHistory.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT h.changed_at, h.status
                FROM application_status_history h
                WHERE h.application_id = @appId
                ORDER BY h.changed_at ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);

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
                    else if (i == 1)
                    {
                        stepLabels[i].ForeColor = Color.Red;
                        stepLabels[i].Text = " ✗ Rejected ";
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
                db.SelectedApplicationId = SelectedApplicationId;
                return db;
            });

            btnProfilePageMyProfile.Click += (s, e) => NavigateTo(() =>
            new profilepage(ApplicantId));

            btnProfilePageJobVacancies.Click += (s, e) => NavigateTo(() =>
            {
                JobVacancies jobs = new JobVacancies();
                jobs.applicantId = ApplicantId;
                jobs.SelectedApplicationId = SelectedApplicationId;
                return jobs;
            });

            btnProfilePageMyApplication.Click += (s, e) => NavigateTo(() =>
            {
                ApplicantPage1 app = new ApplicantPage1();
                app.ApplicantId = ApplicantId;
                app.SelectedApplicationId = SelectedApplicationId;
                return app;
            });

            btnProfilePageDocuments.Click += (s, e) => NavigateTo(() =>
            {
                DocumentPage doc = new DocumentPage();
                doc.ApplicantId = ApplicantId;
                doc.SelectedApplicationId = SelectedApplicationId;
                return doc;
            });

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

        private void btnProfilePageClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfilePageStatusTracking_Click(object sender, EventArgs e)
        {
            StatusTracking_Load(sender, e);
        }

        private void btnProfilePageMyProfile_Click(object sender, EventArgs e)
        {
            profilepage profile = new profilepage(ApplicantId);
            profile.SelectedApplicationId = SelectedApplicationId;
            profile.FormClosed += (s, args) => this.Show();
            this.Hide();             
            profile.Show();
        }
    }
}
