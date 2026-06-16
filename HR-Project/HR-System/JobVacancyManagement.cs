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
    public partial class JobVacancyManagement : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public string UserRole { get; set; } = "";
        public string UserName { get; set; } = "";

        public JobVacancyManagement()
        {
            InitializeComponent();
            this.Load += JobVacancyManagement_Load;
        }

        private void JobVacancyManagement_Load(object sender, EventArgs e)
        {
            LoadOpenJobs();

            UITheme.StyleForm(this);
            UITheme.StyleHeader(panelHeader, lblTitle);
            UITheme.StyleHeaderButton(btnProfilePageClose);
            UITheme.StyleLogoutButton(btnMyDocumentsLogout);
            UITheme.StyleNav(panelNavigation);
            foreach (Control c in panelNavigation.Controls)
                if (c is Button b) UITheme.StyleNavButton(b, b == btnJobVacanciesManagement);
            UITheme.StyleGrid(dgvVacancies);
            UITheme.StylePrimaryButton(btnSaveJobOpening, UITheme.AccentBlue);
            UITheme.StyleSecondaryButton(btnCloseJOb);
            UITheme.StyleSecondaryButton(btnActiveJob);
            UITheme.StyleTextBox(txtJobTitle);
            UITheme.StyleTextBox(txtQualInfo);
            UITheme.StyleComboBox(cmbDepartment);
            UITheme.StyleComboBox(cmbEmploymentType);

            WireNavButtons();
            btnJobVacanciesManagement.Enabled = false;
        }

        private void WireNavButtons()
        {
            btnDashboard.Click += (s, e) => NavigateTo(
                () => new HRDashboard { UserRole = UserRole, UserName = UserName });

            btnApplicants.Click += (s, e) => NavigateTo(
                () => new HRApplicants { UserRole = UserRole, UserName = UserName });

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
        }

        private void NavigateTo(Func<Form> createForm)
        {
            Form next = createForm();
            next.FormClosed += (s, args) => this.Show();
            this.Hide();
            next.Show();
        }

        private void LoadOpenJobs()
        {
            dgvVacancies.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT vacancy_id, position
                FROM job_vacancies
                WHERE status='Open'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvVacancies.Rows.Add(
                        reader["vacancy_id"],
                        reader["position"]);
                }
            }
        }

        private void btnSaveJobOpening_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                INSERT INTO job_vacancies
                (
                    position,
                    department,
                    employment_type,
                    status,
                    qualifications,
                    requirements
                )
                VALUES
                (
                    @position,
                    @department,
                    @employmentType,
                    'Open',
                    @qualifications,
                    @requirements
                )";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@position", txtJobTitle.Text);
                cmd.Parameters.AddWithValue("@department", cmbDepartment.Text);

                string qualifications =
                    string.Join(Environment.NewLine,
                    lstQualifications.Items.Cast<string>());

                List<string> docs = new List<string>();

                if (chkResume.Checked) docs.Add("Resume");
                if (chkGovernmentID.Checked) docs.Add("Government ID");
                if (chkTranscript.Checked) docs.Add("Transcript");
                if (chkCertificates.Checked) docs.Add("Certificates");

                string requirements = string.Join(", ", docs);
                string employmentType = cmbEmploymentType.Text;

                cmd.Parameters.AddWithValue("@employmentType", employmentType);
                cmd.Parameters.AddWithValue("@qualifications", qualifications);
                cmd.Parameters.AddWithValue("@requirements", requirements);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Job vacancy created successfully.");
            LoadOpenJobs();
        }

        private void btnCloseJOb_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) return;

            int vacancyId = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells[0].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE job_vacancies
                SET status='Closed'
                WHERE vacancy_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", vacancyId);
                cmd.ExecuteNonQuery();
            }

            LoadOpenJobs();
        }

        private void btnActiveJob_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) return;

            int vacancyId = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells[0].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE job_vacancies
                SET status='Open'
                WHERE vacancy_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", vacancyId);
                cmd.ExecuteNonQuery();
            }

            LoadOpenJobs();
        }

        private void btnAddQual_Click(object sender, EventArgs e)
        {
            if (txtQualInfo.Text.Trim() == "") return;

            lstQualifications.Items.Add(txtQualInfo.Text.Trim());
            txtQualInfo.Clear();
            txtQualInfo.Focus();
        }

        private void txtJobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void txtQualInfo_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblWelcomeHR_Click(object sender, EventArgs e)
        {
        }

        private void btnMyDocumentsLogout_Click(object sender, EventArgs e)
        {
        }

        private void btnMyDocumentsDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
        }

        private void btnHiringDecision_Click(object sender, EventArgs e)
        {
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void btnScreening_Click(object sender, EventArgs e)
        {
        }
    }
}
