using System;
using System.Windows.Forms;

namespace HR_Project
{
    public partial class WorkExperience : Form
    {
        public int ApplicantId { get; set; }

        public string WorkCompanyName
        {
            get { return txtCompanyName.Text; }
        }

        public string PositionTitle
        {
            get { return txtPosition.Text; }
        }

        public string EmploymentType
        {
            get { return cmbEmploymentType.Text; }
        }

        public DateTime StartDate
        {
            get { return dtpStartDate.Value; }
        }

        public DateTime EndDate
        {
            get { return dtpEndDate.Value; }
        }

        public bool CurrentlyWorking
        {
            get { return chkCurrentWork.Checked; }
        }

        public string JobDescription
        {
            get { return txtJobDescription.Text; }
        }

        public WorkExperience()
        {
            InitializeComponent();
        }

        private void chkCurrentWork_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = !chkCurrentWork.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
