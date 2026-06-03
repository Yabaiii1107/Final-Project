using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Project
{
    public partial class Dashboard : Form
    {
        public string ApplicantName { get; set; }

        public Dashboard()
        {
            InitializeComponent();
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
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            panelNavigation.BringToFront();
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
    }
}
