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
    public partial class Dashboard : Form
    {
        public int ApplicantId { get; set; }

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        private string _applicantName;

        public string ApplicantName
        {
            get { return _applicantName; }
            set
            {
                _applicantName = value;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
            this.Text = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void LoadApplicantInfo()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
        SELECT
            a.first_name,
            a.last_name,
            ap.profile_picture
        FROM applicants a
        LEFT JOIN applicant_profiles ap
            ON a.id = ap.applicant_id
        WHERE a.id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ApplicantId);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblApplicantFirstName.Text =
                        reader["first_name"].ToString();

                    lblApplicantLastName.Text =
                        reader["last_name"].ToString();

                    if (reader["profile_picture"] != DBNull.Value)
                    {
                        byte[] imageBytes =
                            (byte[])reader["profile_picture"];

                        using (MemoryStream ms =
                            new MemoryStream(imageBytes))
                        {
                            picBoxDashboardpfp.Image =
                                Image.FromStream(ms);
                        }
                    }
                }

                reader.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatusTracking_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblMissingDocuments_Click(object sender, EventArgs e)
        {

        }

        private void lblDraft_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationProgress_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxInterviewSchedule_Enter(object sender, EventArgs e)
        {

        }

        private void lblDate1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDocumentsUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lblTranscript_Click(object sender, EventArgs e)
        {

        }

        private void lblDocuStatus2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboardClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblApplicantName1.Text = ApplicantName;

            LoadApplicantInfo();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();

            profilepage profile = new profilepage(ApplicantId);

            profile.Show();
            this.Hide();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void lblApplicantName1_Click(object sender, EventArgs e)
        {

        }
    }
}
