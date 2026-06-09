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
    public partial class JobVacancies : Form
    {
        public int applicantId;

        string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public JobVacancies()
        {
            InitializeComponent();

        }

        private List<Job> jobs = new List<Job>();

        private void LoadJobs()
        {
            jobs.Clear();

            jobs.Add(new Job
            {
                JobId = 1,
                Position = "IT Support Specialist",
                Department = "IT",
                EmploymentType = "Full-Time",
                Status = "Open",
                Qualifications =
                    "Bachelor's Degree in IT or related field",
                Requirements =
                    "Resume\r\nTranscript\r\nValid ID"
            });

            jobs.Add(new Job
            {
                JobId = 2,
                Position = "HR Assistant",
                Department = "Human Resources",
                EmploymentType = "Full-Time",
                Status = "Open",
                Qualifications =
                    "Graduate of Psychology or HRM",
                Requirements =
                    "Resume\r\nTOR\r\nCertificate"
            });

            jobs.Add(new Job
            {
                JobId = 3,
                Position = "Accountant",
                Department = "Finance",
                EmploymentType = "Full-Time",
                Status = "Open",
                Qualifications =
                    "CPA Preferred",
                Requirements =
                    "Resume\r\nBoard Certificate"
            });

            RefreshGrid(jobs);
        }

        private void RefreshGrid(List<Job> source)
        {
            dgvJobVacancies.Rows.Clear();

            foreach (Job job in source)
            {
                dgvJobVacancies.Rows.Add(
                    job.Position,
                    job.Department,
                    job.EmploymentType,
                    job.Status
                );
            }
        }

        private void JobVacancies_Load(object sender, EventArgs e)
        {
            LoadJobs();

            cmbDepartment.Items.Add("All");
            cmbDepartment.Items.Add("IT");
            cmbDepartment.Items.Add("Human Resources");
            cmbDepartment.Items.Add("Finance");

            cmbDepartment.SelectedIndex = 0;
        }

        private void dgvJobVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0)
                return;

            string position =
                dgvJobVacancies.SelectedRows[0]
                .Cells[0].Value.ToString();

            Job selectedJob =
                jobs.FirstOrDefault(j => j.Position == position);

            if (selectedJob != null)
            {
                lblPosition.Text =
                    selectedJob.Position;

                lblDepartments.Text =
                    selectedJob.Department;

                lblEmploymentType.Text =
                    selectedJob.EmploymentType;

                rtbQualification.Text =
                    selectedJob.Qualifications;

                rtbRequirements.Text =
                    selectedJob.Requirements;
            }
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            string keyword =
                txtSearchJob.Text.Trim().ToLower();

            var filtered =
                jobs.Where(j =>
                j.Position.ToLower().Contains(keyword))
                .ToList();

            RefreshGrid(filtered);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.Text == "All")
            {
                RefreshGrid(jobs);
                return;
            }

            var filtered =
                jobs.Where(j =>
                j.Department == cmbDepartment.Text)
                .ToList();

            RefreshGrid(filtered);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a job first.");
                return;
            }

            string position =
                dgvJobVacancies.SelectedRows[0]
                .Cells[0].Value.ToString();

            MessageBox.Show(
                "Application submitted for: " +
                position);
        }

        private void btnProfilePageMyProfile_Click(object sender, EventArgs e)
        {
            profilepage profile = new profilepage(applicantId);

            profile.Show();
            this.Hide();
        }

        private void btnProfilePageDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.ApplicantId = applicantId;

            dashboard.Show();

            this.Hide();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();

            doc.ApplicantId = applicantId;

            doc.Show();
            this.Hide();
        }
    }
}
