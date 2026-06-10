using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            HRApplicants applicants = new HRApplicants();
            applicants.FormClosed += (s, args) => this.Show();
            this.Hide();
            applicants.Show();
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

        private void btnJobVacanciesManagement_Click(object sender, EventArgs e)
        {
            JobVacancyManagement jobForm = new JobVacancyManagement();
            jobForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            jobForm.Show();
        }
    }
}
