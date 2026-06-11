using System;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project.HR_System
{
    public partial class Schedule : Form
    {
        private string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public int ApplicationId { get; set; } = -1;
        public int ApplicantId { get; set; } = -1;
        public string ApplicantName { get; set; } = "";
        public string Position { get; set; } = "";

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            txtApplicantName.Text = ApplicantName;
            txtPositionApplied.Text = Position;

            dtpDate.MinDate = DateTime.Today;
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            cmbType.SelectedIndex = 0;

            btnSaveSchedule.Click += btnSaveSchedule_Click;
            btnCancel.Click += (s, ev) => this.Close();
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (ApplicationId < 0)
            {
                MessageBox.Show(
                    "No application linked to this schedule.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (cmbType.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select an interview type.",
                    "Incomplete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInterviewer.Text))
            {
                MessageBox.Show(
                    "Please enter the interviewer's name.",
                    "Incomplete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Schedule interview for {txtApplicantName.Text}?\n\n" +
                $"Date: {dtpDate.Value:MMMM dd, yyyy}\n" +
                $"Time: {dtpTime.Value:hh:mm tt}\n" +
                $"Type: {cmbType.Text}\n" +
                $"Interviewer: {txtInterviewer.Text}",
                "Confirm Schedule",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                SaveSchedule();

                MessageBox.Show(
                    $"Interview scheduled successfully for {txtApplicantName.Text}.",
                    "Scheduled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while saving the schedule:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveSchedule()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateStatus = @"
                    UPDATE applications
                    SET status = 'Interview'
                    WHERE application_id = @appId";

                MySqlCommand updateCmd = new MySqlCommand(updateStatus, conn);
                updateCmd.Parameters.AddWithValue("@appId", ApplicationId);
                updateCmd.ExecuteNonQuery();

                string historyQuery = @"
                    INSERT INTO application_status_history
                        (application_id, status, changed_at)
                    VALUES
                        (@appId, 'Interview', NOW())";

                MySqlCommand histCmd = new MySqlCommand(historyQuery, conn);
                histCmd.Parameters.AddWithValue("@appId", ApplicationId);
                histCmd.ExecuteNonQuery();

                string checkInterview = @"
                    SELECT COUNT(*) FROM interviews
                    WHERE application_id = @appId";

                MySqlCommand checkCmd = new MySqlCommand(checkInterview, conn);
                checkCmd.Parameters.AddWithValue("@appId", ApplicationId);
                bool exists = Convert.ToInt64(checkCmd.ExecuteScalar()) > 0;

                if (exists)
                {
                    string updateInterview = @"
                        UPDATE interviews
                        SET interview_date = @date,
                            interview_time = @time,
                            interview_type = @type,
                            location_link  = @location,
                            interviewer    = @interviewer,
                            remarks        = @remarks
                        WHERE application_id = @appId";

                    MySqlCommand updCmd = new MySqlCommand(updateInterview, conn);
                    updCmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                    updCmd.Parameters.AddWithValue("@time", dtpTime.Value.TimeOfDay);
                    updCmd.Parameters.AddWithValue("@type", cmbType.Text);
                    updCmd.Parameters.AddWithValue("@location", txtLocationLink.Text.Trim());
                    updCmd.Parameters.AddWithValue("@interviewer", txtInterviewer.Text.Trim());
                    updCmd.Parameters.AddWithValue("@remarks", textBox1.Text.Trim());
                    updCmd.Parameters.AddWithValue("@appId", ApplicationId);
                    updCmd.ExecuteNonQuery();
                }
                else
                {
                    string insertInterview = @"
                        INSERT INTO interviews
                            (application_id, applicant_id,
                             interview_date, interview_time,
                             interview_type, location_link,
                             interviewer, remarks)
                        VALUES
                            (@appId, @applicantId,
                             @date, @time,
                             @type, @location,
                             @interviewer, @remarks)";

                    MySqlCommand insCmd = new MySqlCommand(insertInterview, conn);
                    insCmd.Parameters.AddWithValue("@appId", ApplicationId);
                    insCmd.Parameters.AddWithValue("@applicantId", ApplicantId);
                    insCmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                    insCmd.Parameters.AddWithValue("@time", dtpTime.Value.TimeOfDay);
                    insCmd.Parameters.AddWithValue("@type", cmbType.Text);
                    insCmd.Parameters.AddWithValue("@location", txtLocationLink.Text.Trim());
                    insCmd.Parameters.AddWithValue("@interviewer", txtInterviewer.Text.Trim());
                    insCmd.Parameters.AddWithValue("@remarks", textBox1.Text.Trim());
                    insCmd.ExecuteNonQuery();
                }

                string noteQuery = @"
                    INSERT INTO updates
                        (applicant_id, update_message, created_at)
                    VALUES
                        (@applicantId, @msg, NOW())";

                MySqlCommand noteCmd = new MySqlCommand(noteQuery, conn);
                noteCmd.Parameters.AddWithValue("@applicantId", ApplicantId);
                noteCmd.Parameters.AddWithValue("@msg",
                    $"[Interview Scheduled] Date: {dtpDate.Value:MMMM dd, yyyy} " +
                    $"at {dtpTime.Value:hh:mm tt} | Type: {cmbType.Text} | " +
                    $"Interviewer: {txtInterviewer.Text.Trim()}");
                noteCmd.ExecuteNonQuery();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblInterviewDate_Click(object sender, EventArgs e) { }
        private void lblInterviewTime_Click(object sender, EventArgs e) { }
        private void lblInterviewType_Click(object sender, EventArgs e) { }
        private void lblApplicantName_Click(object sender, EventArgs e) { }
    }
}
