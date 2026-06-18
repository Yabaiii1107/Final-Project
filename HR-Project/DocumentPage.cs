using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using System.IO;
using HR_Project.HR_System;

namespace HR_Project
{
    public partial class DocumentPage : Form
    {
        private string selectedFilePath = "";
        public int ApplicantId { get; set; }

        public int SelectedApplicationId { get; set; }

        private string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public DocumentPage()
        {
            InitializeComponent();
        }

        public DocumentPage(int applicantId)
        {
            InitializeComponent();
            ApplicantId = applicantId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplicantTheme.Apply(this, "btnMyDocumentsDocuments");
            UITheme.StyleActiveNavigationButton(btnMyDocumentsDocuments);
            UITheme.StyleGrid(dgvMyDocumentsStatusTrap);

            WireNavButtons();
            LoadDocuments();
            UpdateDocumentSummary();
            ApplyUploadLock();
        }

        private string GetApplicationStatus()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT status FROM applications WHERE application_id = @appId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", SelectedApplicationId);
                return cmd.ExecuteScalar()?.ToString() ?? "Draft";
            }
        }

        private void ApplyUploadLock()
        {
            string status = GetApplicationStatus();

            bool isLocked = status != "Draft" &&
                            status != "Submitted" &&
                            status != "Withdrawn";

            cmbMyDocumentsDocuType.Enabled = !isLocked;
            btnMyDocumentsBrowse.Enabled = !isLocked;
            btnMyDocumentsUploadFile.Enabled = !isLocked;
            txtMyDocumentsFilePath.Enabled = false;

            if (isLocked)
            {
                lblUploadLockNotice.Visible = true;
                lblUploadLockNotice.Text =
                    "⚠ Document uploads are locked while under review.";
                lblUploadLockNotice.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblUploadLockNotice.Visible = false;
            }
        }

        private void WireNavButtons()
        {
            btnMyDocumentsDashboard.Click += (s, e) => NavigateTo(() =>
            {
                Dashboard db = new Dashboard();
                db.ApplicantId = ApplicantId;
                db.SelectedApplicationId = SelectedApplicationId;
                return db;
            });

            btnMyDocumentsMyProfile.Click += (s, e) => NavigateTo(() =>
                new profilepage(ApplicantId));

            btnMyDocumentsJobVacancies.Click += (s, e) => NavigateTo(() =>
            {
                JobVacancies jobs = new JobVacancies();
                jobs.applicantId = ApplicantId;
                jobs.SelectedApplicationId = SelectedApplicationId;
                return jobs;
            });

            btnMyDocumentsMyApplication.Click += (s, e) => NavigateTo(() =>
            {
                ApplicantPage1 app = new ApplicantPage1();
                app.ApplicantId = ApplicantId;
                app.SelectedApplicationId = SelectedApplicationId;
                return app;
            });

            btnMyDocumentsStatusTracking.Click += (s, e) => NavigateTo(() =>
                new StatusTracking(ApplicantId, SelectedApplicationId));
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) => this.Show();
            this.Hide();
            next.Show();
        }

        private void LoadDocuments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT document_type, status, hr_remarks, file_name
                  FROM applicant_documents
                  WHERE applicant_id = @id";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", ApplicantId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMyDocumentsStatusTrap.AutoGenerateColumns = false;
                dgvMyDocumentsStatusTrap.DataSource = null;
                dgvMyDocumentsStatusTrap.DataSource = dt;

                foreach (DataGridViewRow row in dgvMyDocumentsStatusTrap.Rows)
                {
                    if (row.IsNewRow) continue;

                    string rowStatus = row.Cells["colStatus"].Value?.ToString() ?? "Pending";
                    DataGridViewCell statusCell = row.Cells["colStatus"];

                    switch (rowStatus)
                    {
                        case "Approved":
                        case "Accepted":
                            statusCell.Style.ForeColor = Color.Green;
                            statusCell.Style.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
                            break;
                        case "Rejected":
                        case "Invalid":
                            statusCell.Style.ForeColor = Color.Red;
                            statusCell.Style.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
                            break;
                        case "Under Review":
                            statusCell.Style.ForeColor = Color.DarkOrange;
                            break;
                        case "Pending":
                        default:
                            statusCell.Style.ForeColor = Color.FromArgb(130, 130, 150);
                            break;
                    }
                }
            }
        }

        private void UpdateDocumentSummary()
        {
            chkMyDocumentsResume.Checked = false;
            chkMyDocumentsGovernmentID.Checked = false;
            chkMyDocumentsTranscript.Checked = false;
            chkMyDocumentsCertificates.Checked = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT document_type
                  FROM applicant_documents
                  WHERE applicant_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ApplicantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string docType = reader["document_type"].ToString().Trim();

                        if (docType == "Resume/CV") chkMyDocumentsResume.Checked = true;
                        if (docType == "Government ID") chkMyDocumentsGovernmentID.Checked = true;
                        if (docType == "Transcript") chkMyDocumentsTranscript.Checked = true;
                        if (docType == "Certificates") chkMyDocumentsCertificates.Checked = true;
                    }
                }
            }

            int submitted = 0;
            if (chkMyDocumentsResume.Checked) submitted++;
            if (chkMyDocumentsGovernmentID.Checked) submitted++;
            if (chkMyDocumentsTranscript.Checked) submitted++;
            if (chkMyDocumentsCertificates.Checked) submitted++;

            lblMyDocumentsSubmittedCount.Text = submitted.ToString();
            lblMyDocumentsMissingCount.Text = (4 - submitted).ToString();
        }

        private void btnMyDocumentsBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf|Word Files|*.doc;*.docx|Image Files|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                txtMyDocumentsFilePath.Text = selectedFilePath;
            }
        }

        private void btnMyDocumentsUploadFile_Click(object sender, EventArgs e)
        {
            if (cmbMyDocumentsDocuType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a document type.");
                return;
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }

            string currentStatus = GetApplicationStatus();
            bool isLocked = currentStatus != "Draft" &&
                            currentStatus != "Submitted" &&
                            currentStatus != "Withdrawn";

            if (isLocked)
            {
                MessageBox.Show(
                    "Your application is under review. Documents can no longer be replaced.",
                    "Upload Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ApplyUploadLock();
                return;
            }

            byte[] fileBytes = File.ReadAllBytes(selectedFilePath);
            string docType = cmbMyDocumentsDocuType.Text;
            string fileName = Path.GetFileName(selectedFilePath);
            bool isCertificate = docType == "Certificates";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                if (!isCertificate)
                {
                    string deleteQuery = @"
                    DELETE FROM applicant_documents
                    WHERE applicant_id = @id AND document_type = @type";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@id", ApplicantId);
                    deleteCmd.Parameters.AddWithValue("@type", docType);
                    deleteCmd.ExecuteNonQuery();
                }

                string insertQuery = @"
                INSERT INTO applicant_documents
                    (applicant_id, document_type, file_name, file_data, status)
                VALUES
                    (@id, @type, @name, @file, 'Pending')";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@id", ApplicantId);
                insertCmd.Parameters.AddWithValue("@type", docType);
                insertCmd.Parameters.AddWithValue("@name", fileName);
                insertCmd.Parameters.AddWithValue("@file", fileBytes);
                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                "Document uploaded successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            selectedFilePath = "";
            txtMyDocumentsFilePath.Text = "";
            cmbMyDocumentsDocuType.SelectedIndex = -1;

            LoadDocuments();
            UpdateDocumentSummary();
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

        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void clbRequirements_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panelProfilePageHeader_Paint(object sender, PaintEventArgs e) { }
        private void cmbMyDocumentsDocuType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnMyDocumentsDocuments_Click(object sender, EventArgs e) { }

        private void btnMyDocumentsMyProfile_Click(object sender, EventArgs e)
        {
            profilepage profile = new profilepage(ApplicantId);
            profile.SelectedApplicationId = SelectedApplicationId;
            profile.FormClosed += (s, args) => this.Show(); 
            this.Hide();                                
            profile.Show();
        }
    }
}
