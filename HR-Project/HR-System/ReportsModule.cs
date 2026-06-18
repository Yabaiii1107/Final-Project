using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
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

        private bool _navWired = false;

        public ReportsModule()
        {
            InitializeComponent();
            this.Load += ReportsModule_Load;
        }

        private void ReportsModule_Load(object sender, EventArgs e)
        {
            dtpDataFrom.Value = DateTime.Today.AddDays(-90);
            dtpDataTo.Value = DateTime.Today;

            ApplyTheme();
            WireNavButtons();

            btnGenerate.Click += btnGenerate_Click;
        }

        private void ApplyTheme()
        {
            this.BackgroundImage = null;
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackColor = UITheme.BgPage;

            panelMyDocumentsHeader.BackColor = UITheme.BgHeader;
            panelMyDocumentsHeader.BackgroundImage = null;
            lblMyDocumentsTitle.ForeColor = UITheme.TextLight;
            lblMyDocumentsTitle.Font = UITheme.FontTitle;

            btnProfilePageClose.FlatStyle = FlatStyle.Flat;
            btnProfilePageClose.FlatAppearance.BorderSize = 0;
            btnProfilePageClose.BackColor = Color.Transparent;
            btnProfilePageClose.ForeColor = Color.FromArgb(255, 80, 80);
            btnProfilePageClose.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            btnProfilePageClose.UseVisualStyleBackColor = false;

            btnMyDocumentsLogout.FlatStyle = FlatStyle.Flat;
            btnMyDocumentsLogout.FlatAppearance.BorderSize = 1;
            btnMyDocumentsLogout.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 80);
            btnMyDocumentsLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 80, 80);
            btnMyDocumentsLogout.BackColor = Color.Transparent;
            btnMyDocumentsLogout.ForeColor = Color.FromArgb(255, 80, 80);
            btnMyDocumentsLogout.UseVisualStyleBackColor = false;

            panelMyDocumentsNavigation.BackColor = UITheme.BgNav;
            panelMyDocumentsNavigation.BackgroundImage = null;

            foreach (Control c in panelMyDocumentsNavigation.Controls)
            {
                if (c is Button b)
                {
                    bool isActive = b == btnReports;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseOverBackColor = UITheme.NavHover;
                    b.FlatAppearance.MouseDownBackColor = UITheme.NavHover;
                    b.BackColor = isActive ? UITheme.NavActive : Color.Transparent;
                    b.ForeColor = UITheme.TextLight;
                    b.Font = isActive ? UITheme.FontNavActive : UITheme.FontNav;
                    b.Cursor = isActive ? Cursors.Default : Cursors.Hand;
                    b.UseVisualStyleBackColor = false;
                }
            }

            grpReportTypes.BackColor = Color.White;
            grpReportTypes.ForeColor = UITheme.TextPrimary;
            grpReportTypes.Font = UITheme.FontBtn;
            grpReportTypes.BackgroundImage = null;

            grpFilters.BackColor = Color.White;
            grpFilters.ForeColor = UITheme.TextPrimary;
            grpFilters.Font = UITheme.FontBtn;
            grpFilters.BackgroundImage = null;

            grpOutput.BackColor = Color.White;
            grpOutput.ForeColor = UITheme.TextPrimary;
            grpOutput.Font = UITheme.FontBtn;
            grpOutput.BackgroundImage = null;

            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.BackColor = UITheme.AccentBlue;
            btnGenerate.ForeColor = UITheme.TextLight;
            btnGenerate.Font = UITheme.FontBtn;
            btnGenerate.UseVisualStyleBackColor = false;

            UITheme.StyleGrid(dgvReportView);

            if (grpOutput.Controls["btnExportCsv"] == null)
            {
                Button btnExportCsv = new Button();
                btnExportCsv.Name = "btnExportCsv";
                btnExportCsv.Text = "📄 Export to CSV";
                btnExportCsv.Size = new Size(140, 30);
                btnExportCsv.Location = new Point(grpOutput.Width - 310, grpOutput.Height - 42);
                btnExportCsv.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnExportCsv.FlatStyle = FlatStyle.Flat;
                btnExportCsv.FlatAppearance.BorderSize = 0;
                btnExportCsv.BackColor = UITheme.AccentGreen;
                btnExportCsv.ForeColor = Color.White;
                btnExportCsv.Font = UITheme.FontBtn;
                btnExportCsv.UseVisualStyleBackColor = false;
                btnExportCsv.Click += BtnExportCsv_Click;
                grpOutput.Controls.Add(btnExportCsv);

                Button btnPrint = new Button();
                btnPrint.Name = "btnPrint";
                btnPrint.Text = "🖨️ Print Report";
                btnPrint.Size = new Size(140, 30);
                btnPrint.Location = new Point(grpOutput.Width - 160, grpOutput.Height - 42);
                btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnPrint.FlatStyle = FlatStyle.Flat;
                btnPrint.FlatAppearance.BorderSize = 0;
                btnPrint.BackColor = UITheme.AccentBlue;
                btnPrint.ForeColor = Color.White;
                btnPrint.Font = UITheme.FontBtn;
                btnPrint.UseVisualStyleBackColor = false;
                btnPrint.Click += BtnPrint_Click;
                grpOutput.Controls.Add(btnPrint);
            }
        }

        private void WireNavButtons()
        {
            if (_navWired) return;
            _navWired = true;

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
                if (MessageBox.Show("Are you sure you want to logout?",
                        "Logout", MessageBoxButtons.YesNo,
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!rbAllApplicants.Checked && !rbPending.Checked &&
                !rbInterviews.Checked && !rbOutcome.Checked && !rbMissingDocs.Checked)
            {
                MessageBox.Show("Please select a report type first.",
                    "No Report Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDataFrom.Value.Date > dtpDataTo.Value.Date)
            {
                MessageBox.Show("\"Date From\" cannot be later than \"Date To\".",
                    "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Error generating report:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateAllApplicants()
        {
            UpdateColumnHeaders("Application Date", "Status");
            const string query = @"
                SELECT
                    ap.id                                       AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)      AS CandidateName,
                    COALESCE(j.position, 'No Application')      AS PositionApplied,
                    DATE_FORMAT(a.application_date,'%b %d, %Y') AS DataTarget,
                    COALESCE(a.status, 'Draft')                 AS ReportStatus
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
                    ap.id                                                AS ID,
                    CONCAT(ap.first_name,' ',ap.last_name)               AS CandidateName,
                    COALESCE(j.position, 'N/A')                          AS PositionApplied,
                    CONCAT(DATEDIFF(NOW(), a.application_date), ' days') AS DataTarget,
                    a.status                                             AS ReportStatus
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
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%resume%'      THEN 1 ELSE 0 END) = 0, 'Resume/CV',     NULL),
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%government%'  THEN 1 ELSE 0 END) = 0, 'Government ID', NULL),
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%transcript%'  THEN 1 ELSE 0 END) = 0, 'Transcript',    NULL),
                        IF(SUM(CASE WHEN LOWER(d.document_type) LIKE '%certificate%' THEN 1 ELSE 0 END) = 0, 'Certificates',  NULL)
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
                cmd.Parameters.AddWithValue("@to",
                    dtpDataTo.Value.Date.AddDays(1).AddSeconds(-1));

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

        private void BtnExportCsv_Click(object sender, EventArgs e)
        {
            if (dgvReportView.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please generate a report first.",
                    "Nothing to Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"HR_Report_{DateTime.Today:yyyy-MM-dd}.csv";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                StringBuilder sb = new StringBuilder();

                var headers = new string[dgvReportView.Columns.Count];
                for (int i = 0; i < dgvReportView.Columns.Count; i++)
                    headers[i] = "\"" + dgvReportView.Columns[i].HeaderText + "\"";
                sb.AppendLine(string.Join(",", headers));

                foreach (DataGridViewRow row in dgvReportView.Rows)
                {
                    var cells = new string[dgvReportView.Columns.Count];
                    for (int i = 0; i < dgvReportView.Columns.Count; i++)
                        cells[i] = "\"" + (row.Cells[i].Value?.ToString() ?? "") + "\"";
                    sb.AppendLine(string.Join(",", cells));
                }

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show($"Report exported successfully to:\n{sfd.FileName}",
                    "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReportView.Rows.Count == 0)
            {
                MessageBox.Show("No data to print. Please generate a report first.",
                    "Nothing to Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportTitle = grpOutput.Text;
            string dateRange =
                $"Date Range: {dtpDataFrom.Value:MMM dd, yyyy} — {dtpDataTo.Value:MMM dd, yyyy}";

            var colHeaders = new string[dgvReportView.Columns.Count];
            for (int i = 0; i < dgvReportView.Columns.Count; i++)
                colHeaders[i] = dgvReportView.Columns[i].HeaderText;

            var rows = new List<string[]>();
            foreach (DataGridViewRow row in dgvReportView.Rows)
            {
                var cells = new string[dgvReportView.Columns.Count];
                for (int i = 0; i < dgvReportView.Columns.Count; i++)
                    cells[i] = row.Cells[i].Value?.ToString() ?? "";
                rows.Add(cells);
            }

            using (System.Drawing.Printing.PrintDocument pd =
                   new System.Drawing.Printing.PrintDocument())
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = pd;

                int pageRowIndex = 0;

                pd.PrintPage += (s, ev) =>
                {
                    var g = ev.Graphics;
                    float y = ev.MarginBounds.Top;
                    float left = ev.MarginBounds.Left;
                    float pageWidth = ev.MarginBounds.Width;

                    using (Font titleFont = new Font("Segoe UI", 13f, FontStyle.Bold))
                        g.DrawString("HR System — " + reportTitle, titleFont,
                            Brushes.Black, left, y);
                    y += 25;

                    using (Font subFont = new Font("Segoe UI", 9f))
                        g.DrawString(dateRange, subFont, Brushes.Gray, left, y);
                    y += 20;

                    g.DrawLine(Pens.Gray, left, y, left + pageWidth, y);
                    y += 8;

                    float colWidth = pageWidth / colHeaders.Length;

                    using (Font headerFont = new Font("Segoe UI", 9f, FontStyle.Bold))
                    {
                        for (int i = 0; i < colHeaders.Length; i++)
                            g.DrawString(colHeaders[i], headerFont,
                                Brushes.Black, left + i * colWidth, y);
                    }
                    y += 20;
                    g.DrawLine(Pens.LightGray, left, y, left + pageWidth, y);
                    y += 4;

                    using (Font rowFont = new Font("Segoe UI", 8.5f))
                    {
                        while (pageRowIndex < rows.Count &&
                               y < ev.MarginBounds.Bottom - 20)
                        {
                            string[] row = rows[pageRowIndex++];
                            for (int i = 0; i < row.Length; i++)
                                g.DrawString(row[i], rowFont,
                                    Brushes.Black, left + i * colWidth, y);
                            y += 18;
                        }
                    }

                    ev.HasMorePages = pageRowIndex < rows.Count;
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                    pd.Print();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void btnHiringDecision_Click(object sender, EventArgs e) { }
        private void btnInterviews_Click(object sender, EventArgs e) { }
        private void btnScreening_Click(object sender, EventArgs e) { }
        private void btnJobVacanciesManagement_Click(object sender, EventArgs e) { }
        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e) { }
        private void btnApplicants_Click(object sender, EventArgs e) { }
        private void btnMyDocumentsLogout_Click(object sender, EventArgs e) { }
    }
}
