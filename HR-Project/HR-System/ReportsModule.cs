using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project.HR_System
{
    public partial class ReportsModule : Form
    {
        private readonly string _connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public string UserRole { get; set; } = "";
        public string UserName { get; set; } = "";

        public ReportsModule()
        {
            InitializeComponent();
        }

        private void ReportsModule_Load(object sender, EventArgs e)
        {
            dtpDataFrom.Value = DateTime.Today.AddDays(-90);
            dtpDataTo.Value = DateTime.Today;

            btnGenerate.Click += btnGenerate_Click;

            WireNavButtons();

            btnReports.Enabled = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!rbAllApplicants.Checked &&
                !rbPending.Checked &&
                !rbInterviews.Checked &&
                !rbOutcome.Checked &&
                !rbMissingDocs.Checked)
            {
                MessageBox.Show(
                    "Please select a report type first.",
                    "No Report Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpDataFrom.Value.Date > dtpDataTo.Value.Date)
            {
                MessageBox.Show(
                    "\"Date From\" cannot be later than \"Date To\".",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (rbAllApplicants.Checked) GenerateAllApplicants();
                else if (rbPending.Checked) GeneratePending();
                else if (rbInterviews.Checked) GenerateInterviews();
                else if (rbOutcome.Checked) GenerateOutcome();
                else if (rbMissingDocs.Checked) GenerateMissingDocs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating report:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GenerateAllApplicants()
        {
            UpdateColumnHeaders("Application Date", "Current Status");

            const string query = @"
                SELECT
                    ap.id                                    AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)   AS CandidateName,
                    COALESCE(j.position, 'No Application')   AS PositionApplied,
                    DATE_FORMAT(a.application_date,'%b %d, %Y') AS DataTarget,
                    COALESCE(a.status, 'Draft')              AS ReportStatus
                FROM applicants ap
                LEFT JOIN applications a  ON ap.id = a.applicant_id
                LEFT JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE a.application_date BETWEEN @from AND @to
                   OR a.application_date IS NULL
                ORDER BY ap.last_name, ap.first_name";

            LoadReport(query);
        }

        private void GeneratePending()
        {
            UpdateColumnHeaders("Days Pending", "Pipeline Stage");

            const string query = @"
                SELECT
                    ap.id                                       AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)      AS CandidateName,
                    COALESCE(j.position, 'N/A')                 AS PositionApplied,
                    CONCAT(DATEDIFF(NOW(), a.application_date), ' days') AS DataTarget,
                    a.status                                    AS ReportStatus
                FROM applicants ap
                INNER JOIN applications a  ON ap.id = a.applicant_id
                LEFT  JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE a.status IN
                    ('Submitted','Under Review','Shortlisted','Interview','Final Review')
                  AND a.application_date BETWEEN @from AND @to
                ORDER BY a.application_date ASC";

            LoadReport(query);
        }

        private void GenerateInterviews()
        {
            UpdateColumnHeaders("Interview Date & Time", "Interview Status");

            const string query = @"
                SELECT
                    ap.id                                       AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)      AS CandidateName,
                    COALESCE(j.position, 'N/A')                 AS PositionApplied,
                    CASE
                        WHEN i.interview_date IS NOT NULL
                        THEN CONCAT(
                            DATE_FORMAT(i.interview_date,'%b %d, %Y'),
                            ' ',
                            TIME_FORMAT(i.interview_time,'%h:%i %p'))
                        ELSE 'TBA'
                    END                                         AS DataTarget,
                    a.status                                    AS ReportStatus
                FROM applicants ap
                INNER JOIN applications a   ON ap.id = a.applicant_id
                LEFT  JOIN job_vacancies j  ON a.vacancy_id = j.vacancy_id
                LEFT  JOIN interviews i     ON a.application_id = i.application_id
                WHERE a.status = 'Interview'
                  AND a.application_date BETWEEN @from AND @to
                ORDER BY i.interview_date ASC, i.interview_time ASC";

            LoadReport(query);
        }

        private void GenerateOutcome()
        {
            UpdateColumnHeaders("Decision Date", "Final Outcome");

            const string query = @"
                SELECT
                    ap.id                                       AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)      AS CandidateName,
                    COALESCE(j.position, 'N/A')                 AS PositionApplied,
                    DATE_FORMAT(
                        (SELECT MAX(h.changed_at)
                         FROM application_status_history h
                         WHERE h.application_id = a.application_id
                           AND h.status IN ('Accepted','Rejected')),
                        '%b %d, %Y')                            AS DataTarget,
                    a.status                                    AS ReportStatus
                FROM applicants ap
                INNER JOIN applications a  ON ap.id = a.applicant_id
                LEFT  JOIN job_vacancies j ON a.vacancy_id = j.vacancy_id
                WHERE a.status IN ('Accepted','Rejected')
                  AND a.application_date BETWEEN @from AND @to
                ORDER BY a.status, ap.last_name";

            LoadReport(query);
        }

        private void GenerateMissingDocs()
        {
            UpdateColumnHeaders("Missing Documents", "Missing Count");

            const string query = @"
                SELECT
                    ap.id                                           AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)          AS CandidateName,
                    COALESCE(j.position, 'N/A')                     AS PositionApplied,
                    TRIM(BOTH ', ' FROM CONCAT_WS(', ',
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%resume%'        THEN 1 ELSE 0 END) = 0, 'Resume/CV',       NULL),
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%government%'    THEN 1 ELSE 0 END) = 0, 'Government ID',   NULL),
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%transcript%'    THEN 1 ELSE 0 END) = 0, 'Transcript',      NULL),
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%certificate%'   THEN 1 ELSE 0 END) = 0, 'Certificates',    NULL)
                    ))                                              AS DataTarget,
                    CONCAT(
                        (4 -
                            (IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%resume%'      THEN 1 ELSE 0 END) > 0, 1, 0) +
                             IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%government%'  THEN 1 ELSE 0 END) > 0, 1, 0) +
                             IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%transcript%'  THEN 1 ELSE 0 END) > 0, 1, 0) +
                             IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%certificate%' THEN 1 ELSE 0 END) > 0, 1, 0))
                        ), ' / 4 missing')                          AS ReportStatus
                FROM applicants ap
                INNER JOIN applications a   ON ap.id = a.applicant_id
                LEFT  JOIN job_vacancies j  ON a.vacancy_id = j.vacancy_id
                LEFT  JOIN applicant_documents d ON ap.id = d.applicant_id
                WHERE a.status NOT IN ('Draft','Withdrawn')
                  AND a.application_date BETWEEN @from AND @to
                GROUP BY ap.id, ap.first_name, ap.last_name, j.position, a.application_id
                HAVING DataTarget <> ''
                ORDER BY ap.last_name";

            LoadReport(query);
        }

        private void LoadReport(string query)
        {
            dgvReportView.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", dtpDataFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtpDataTo.Value.Date.AddDays(1).AddSeconds(-1));

                var adapter = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dgvReportView.Rows.Add(
                        row["ID"].ToString(),
                        row["CandidateName"].ToString(),
                        row["PositionApplied"].ToString(),
                        row["DataTarget"].ToString(),
                        row["ReportStatus"].ToString());
                }
            }

            grpOutput.Text =
                $"📋 Live Generated Report Output Viewer  —  {dgvReportView.Rows.Count} record(s)";
        }

        private void UpdateColumnHeaders(string dataTargetHeader, string statusHeader)
        {
            colDataTarget.HeaderText = dataTargetHeader;
            colReportStatus.HeaderText = statusHeader;
        }

        private void WireNavButtons()
        {
            btnMyDocumentsDashboard.Click += (s, e) => NavigateTo(
                () => new HRDashboard { UserRole = UserRole, UserName = UserName });

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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
        }

        private void btnHiringDecision_Click(object sender, EventArgs e)
        {
        }

        private void btnJobVacanciesManagement_Click(object sender, EventArgs e)
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
