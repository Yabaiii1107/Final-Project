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
    public partial class DocumentPage : Form
    {
        private string selectedFilePath = "";

        public int ApplicantId { get; set; }

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";


        public DocumentPage()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void LoadDocuments()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT
                    document_type,
                    status,
                    hr_remarks,
                    file_name
                FROM applicant_documents
                WHERE applicant_id=@id";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@id",
                    ApplicantId);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvMyDocumentsStatusTrap.DataSource = dt;
            }
        }

        private void UpdateDocumentSummary()
        {
            chkMyDocumentsResume.Checked = false;
            chkMyDocumentsGovernmentID.Checked = false;
            chkMyDocumentsTranscript.Checked = false;
            chkMyDocumentsCertificates.Checked = false;

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
                    string docType = reader["document_type"].ToString();

                    if (docType.Trim() == "Resume/CV")
                    {
                        chkMyDocumentsResume.Checked = true;
                    }

                    if (docType.Trim() == "Government ID")
                    {
                        chkMyDocumentsGovernmentID.Checked = true;
                    }

                    if (docType.Trim() == "Transcript")
                    {
                        chkMyDocumentsTranscript.Checked = true;
                    }

                    if (docType.Trim() == "Certificates")
                    {
                        chkMyDocumentsCertificates.Checked = true;
                    }
                }

                reader.Close();
            }

            int submitted = 0;

            if (chkMyDocumentsResume.Checked) submitted++;
            if (chkMyDocumentsGovernmentID.Checked) submitted++;
            if (chkMyDocumentsTranscript.Checked) submitted++;
            if (chkMyDocumentsCertificates.Checked) submitted++;

            lblMyDocumentsSubmittedCount.Text =
                submitted.ToString();

            lblMyDocumentsMissingCount.Text =
                (4 - submitted).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDocuments();
            UpdateDocumentSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void clbRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelProfilePageHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMyDocumentsBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter =
                "PDF Files|*.pdf|Word Files|*.doc;*.docx|Image Files|*.jpg;*.png";

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
                MessageBox.Show("Select document type.");
                return;
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Select a file first.");
                return;
            }

            byte[] fileBytes =
                File.ReadAllBytes(selectedFilePath);

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"INSERT INTO applicant_documents
                (
                    applicant_id,
                    document_type,
                    file_name,
                    file_data
                )
                VALUES
                (
                    @id,
                    @type,
                    @name,
                    @file
                )";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ApplicantId);

                cmd.Parameters.AddWithValue("@type",
                    cmbMyDocumentsDocuType.Text);

                cmd.Parameters.AddWithValue("@name",
                    Path.GetFileName(selectedFilePath));

                cmd.Parameters.AddWithValue("@file",
                    fileBytes);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Document Uploaded.");

                LoadDocuments();
                UpdateDocumentSummary();
            }
        }

        private void cmbMyDocumentsDocuType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.ApplicantId = ApplicantId;

            dashboard.Show();
            this.Hide();
        }

        private void btnMyDocumentsMyProfile_Click(object sender, EventArgs e)
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

        private void btnMyDocumentsJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacancies jobs = new JobVacancies();

            jobs.applicantId = ApplicantId;

            jobs.Show();
            this.Hide();

            panelMyDocumentsNavigation.BringToFront();
        }

        private void btnMyDocumentsMyApplication_Click(object sender, EventArgs e)
        {
            ApplicantPage1 app =
                new ApplicantPage1();

            app.ApplicantId = ApplicantId;

            app.Show();

            this.Hide();
        }
    }
    }
 
