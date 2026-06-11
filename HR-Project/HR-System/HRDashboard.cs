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
    public partial class HRDashboard : Form
    {
        public string UserRole { get; set; }
        public string UserName { get; set; }
        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public HRDashboard()
        {
            InitializeComponent();
        }

        private void HRDashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeHR.Text = $"Welcome {UserName}!";
            WireNavButtons();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            LoadStatCards();
            LoadPendingReviews();
            LoadUpcomingInterviews();
            LoadRecentUpdates();
        }

        private void LoadStatCards()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                lblApplicantCount.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM applicants").ToString();

                lblOpenJobsCount.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM job_vacancies WHERE status = 'Open'").ToString();

                lblInterviewsCount.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM applications WHERE status = 'Interview'").ToString();

                lblAcceptedCount.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM applications WHERE status = 'Accepted'").ToString();
            }
        }

        private long GetCount(MySqlConnection conn, string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        private void LoadPendingReviews()
        {
            dgvPendingReviews.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        CONCAT(ap.first_name, ' ', ap.last_name) AS ApplicantName,
                        COALESCE(j.position, 'N/A')              AS Position,
                        a.status                                 AS Status
                    FROM applicants ap
                    INNER JOIN applications a  ON ap.id = a.applicant_id
                    LEFT  JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                    WHERE a.status IN ('Under Review', 'Shortlisted', 'Final Review')
                    ORDER BY a.application_date ASC
                    LIMIT 20";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvPendingReviews.Rows.Add(
                            reader["ApplicantName"].ToString(),
                            reader["Position"].ToString(),
                            reader["Status"].ToString());
                    }
                }
            }
        }

        private void LoadUpcomingInterviews()
        {
            dgvUpcomingInterviews.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        CONCAT(ap.first_name, ' ', ap.last_name)    AS ApplicantName,
                        COALESCE(j.position, 'N/A')                 AS Position,
                        DATE_FORMAT(i.interview_date, '%b %d, %Y')  AS InterviewDate,
                        TIME_FORMAT(i.interview_time, '%h:%i %p')   AS InterviewTime
                    FROM interviews i
                    INNER JOIN applications a  ON i.application_id = a.application_id
                    INNER JOIN applicants ap   ON a.applicant_id = ap.id
                    LEFT  JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                    WHERE i.interview_date >= CURDATE()
                      AND a.status = 'Interview'
                    ORDER BY i.interview_date ASC, i.interview_time ASC
                    LIMIT 20";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvUpcomingInterviews.Rows.Add(
                            reader["ApplicantName"].ToString(),
                            reader["Position"].ToString(),
                            reader["InterviewDate"].ToString(),
                            reader["InterviewTime"].ToString());
                    }
                }
            }
        }

        private void LoadRecentUpdates()
        {
            dgvRecentUpdates.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        CONCAT(ap.first_name, ' ', ap.last_name)        AS ApplicantName,
                        COALESCE(j.position, 'N/A')                     AS Position,
                        a.status                                        AS CurrentStatus,
                        DATE_FORMAT(h.changed_at, '%b %d, %Y %h:%i %p') AS DateUpdated
                    FROM application_status_history h
                    INNER JOIN applications a  ON h.application_id = a.application_id
                    INNER JOIN applicants ap   ON a.applicant_id = ap.id
                    LEFT  JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                    ORDER BY h.changed_at DESC
                    LIMIT 20";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvRecentUpdates.Rows.Add(
                            reader["ApplicantName"].ToString(),
                            reader["Position"].ToString(),
                            reader["CurrentStatus"].ToString(),
                            reader["DateUpdated"].ToString());
                    }
                }
            }
        }

        private void WireNavButtons()
        {
            btnApplicants.Click += (s, e) => NavigateTo(
                () => new HRApplicants { UserRole = UserRole, UserName = UserName });

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

            btnMyDocumentsDashboard.Enabled = false;
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) =>
            {
                this.Show();
                LoadDashboard();
            };
            this.Hide();
            next.Show();
        }

        private void btnApplicants_Click(object sender, EventArgs e) { }
        private void btnProfilePageClose_Click(object sender, EventArgs e) { }
        private void btnMyDocumentsLogout_Click(object sender, EventArgs e) { }
        private void btnJobVacanciesManagement_Click(object sender, EventArgs e) { }
        private void btnScreening_Click(object sender, EventArgs e) { }
        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e) { }
        private void btnInterviews_Click(object sender, EventArgs e) { }
        private void btnHiringDecision_Click(object sender, EventArgs e) { }
        private void btnReports_Click(object sender, EventArgs e) { }
    }
}
