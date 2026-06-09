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
    public partial class ApplicantPage1 : Form
    {
        public int ApplicantId { get; set; }

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

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

        private void LoadApplication()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"SELECT
                    a.application_date,
                    a.status,
                    a.profile_completed,
                    a.documents_uploaded,
                    a.hr_review,
                    a.technical_interview,

                    j.position,
                    j.department

                FROM applications a

                INNER JOIN job_vacancies j
                    ON a.vacancy_id = j.vacancy_id

                WHERE a.applicant_id = @id

                ORDER BY a.application_date DESC

                LIMIT 1";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    ApplicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtJobTitle.Text =
                        reader["position"].ToString();

                    txtDept.Text =
                        reader["department"].ToString();

                    dtpDataFiled.Value =
                        Convert.ToDateTime(
                        reader["application_date"]);

                    lblCurrentStatus.Text =
                        "Current Status: " +
                        reader["status"].ToString();

                    lblStatusDescription.Text =
                        GetStatusDescription(
                        reader["status"].ToString());

                    clbApplicationSteps.SetItemChecked(
                        0,
                        Convert.ToBoolean(
                        reader["profile_completed"]));

                    clbApplicationSteps.SetItemChecked(
                        1,
                        Convert.ToBoolean(
                        reader["documents_uploaded"]));

                    clbApplicationSteps.SetItemChecked(
                        2,
                        Convert.ToBoolean(
                        reader["hr_review"]));

                    clbApplicationSteps.SetItemChecked(
                        3,
                        Convert.ToBoolean(
                        reader["technical_interview"]));
                }

                reader.Close();
            }
        }

        private string GetStatusDescription(string status)
        {
            switch (status)
            {
                case "Submitted":
                    return "Application submitted successfully.";

                case "Under Review":
                    return "HR is reviewing your application.";

                case "Shortlisted":
                    return "You have been shortlisted.";

                case "Interview":
                    return "Interview schedule will be sent.";

                case "Final Review":
                    return "Final evaluation in progress.";

                case "Accepted":
                    return "Congratulations! You have been accepted.";

                case "Rejected":
                    return "Application was not selected.";

                default:
                    return "Application in progress.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpPositionInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnMyDocumentsMyApplication_Click(object sender, EventArgs e)
        {

        }

        private void ApplicantPage1_Load(object sender, EventArgs e)
        {
            LoadApplication();
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

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.ApplicantId = ApplicantId;

            dashboard.Show();

            this.Hide();
        }

        private void btnMyDocumentsJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacancies jobs = new JobVacancies();

            jobs.applicantId = ApplicantId;

            jobs.Show();
            this.Hide();

            panelMyApplicationNavigation.BringToFront();
        }

        private void btnMyDocumentsDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();

            doc.ApplicantId = ApplicantId;

            doc.Show();
            this.Hide();

            panelMyApplicationNavigation.BringToFront();
        }

        private void btnMyDocumentsDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.ApplicantId = ApplicantId;

            dashboard.Show();

            this.Hide();
        }

        private void btnProfilePageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
