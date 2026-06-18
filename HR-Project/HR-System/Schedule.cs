using System;
using System.Runtime.InteropServices;
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

        private bool _existingScheduleLoaded = false;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        private const uint EM_SETCUEBANNER = 0x1501;

        private static void SetPlaceholder(TextBox tb, string text)
        {
            SendMessage(tb.Handle, EM_SETCUEBANNER, (IntPtr)1, text);
        }

        public Schedule()
        {
            InitializeComponent();

            this.Load += Schedule_Load;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            txtApplicantName.Text = ApplicantName;
            txtApplicantName.ReadOnly = true;

            txtPositionApplied.Text = Position;
            txtPositionApplied.ReadOnly = true;

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;

            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
            dtpTime.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                DateTime.Today.Day,
                9, 0, 0);   

            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;

            UITheme.StyleForm(this);
            this.BackColor = UITheme.BgPage;
            UITheme.StyleTextBox(txtApplicantName);
            UITheme.StyleTextBox(txtPositionApplied);
            UITheme.StyleTextBox(txtLocationLink);
            UITheme.StyleTextBox(txtInterviewer);
            UITheme.StyleTextBox(textBox1);
            UITheme.StyleComboBox(cmbType);
            UITheme.StylePrimaryButton(btnSaveSchedule, UITheme.AccentGreen);
            UITheme.StyleSecondaryButton(btnCancel);

            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            btnSaveSchedule.Click += btnSaveSchedule_Click;
            btnCancel.Click += (s, ev) => this.Close();

            UpdateLocationLabel();

            if (ApplicationId >= 0)
                TryLoadExistingSchedule();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLocationLabel();
        }

        private void UpdateLocationLabel()
        {
            if (cmbType.Text == "Online")
            {
                lblLocationLink.Text = "Meeting Link:";
                SetPlaceholder(txtLocationLink, "e.g. https://meet.google.com/...");
            }
            else
            {
                lblLocationLink.Text = "Location / Address:";
                SetPlaceholder(txtLocationLink, "e.g. 3F HR Office, Main Building");
            }
        }

        private void TryLoadExistingSchedule()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT interview_date, interview_time,
                               interview_type, location_link,
                               interviewer, remarks
                        FROM interviews
                        WHERE application_id = @appId
                        LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appId", ApplicationId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return;

                        _existingScheduleLoaded = true;

                        if (reader["interview_date"] != DBNull.Value)
                        {
                            DateTime existingDate =
                                Convert.ToDateTime(reader["interview_date"]);
                            dtpDate.Value = existingDate >= DateTime.Today
                                ? existingDate
                                : DateTime.Today;
                        }

                        if (reader["interview_time"] != DBNull.Value)
                        {
                            TimeSpan ts = (TimeSpan)reader["interview_time"];
                            dtpTime.Value = dtpTime.Value.Date + ts;
                        }

                        string existingType =
                            reader["interview_type"]?.ToString() ?? "";
                        int typeIdx = cmbType.Items.IndexOf(existingType);
                        if (typeIdx >= 0) cmbType.SelectedIndex = typeIdx;

                        txtLocationLink.Text = reader["location_link"]?.ToString() ?? "";
                        txtInterviewer.Text = reader["interviewer"]?.ToString() ?? "";
                        textBox1.Text = reader["remarks"]?.ToString() ?? "";
                    }
                }
            }
            catch
            {
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (ApplicationId < 0)
            {
                MessageBox.Show(
                    "No application linked to this schedule.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbType.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select an interview type (Online or Onsite).",
                    "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInterviewer.Text))
            {
                MessageBox.Show(
                    "Please enter the interviewer's name.",
                    "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocationLink.Text))
            {
                string fieldName = cmbType.Text == "Online"
                    ? "meeting link" : "interview location";
                MessageBox.Show(
                    $"Please enter the {fieldName}.",
                    "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Interview date cannot be in the past.",
                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string action = _existingScheduleLoaded ? "Reschedule" : "Schedule";

            DialogResult confirm = MessageBox.Show(
                $"{action} interview for {txtApplicantName.Text}?\n\n" +
                $"Date:        {dtpDate.Value:MMMM dd, yyyy}\n" +
                $"Time:        {dtpTime.Value:hh:mm tt}\n" +
                $"Type:        {cmbType.Text}\n" +
                $"Interviewer: {txtInterviewer.Text.Trim()}",
                $"Confirm {action}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                SaveSchedule();

                string successMsg = _existingScheduleLoaded
                    ? $"Interview rescheduled successfully for {txtApplicantName.Text}."
                    : $"Interview scheduled successfully for {txtApplicantName.Text}.";

                MessageBox.Show(
                    successMsg,
                    _existingScheduleLoaded ? "Rescheduled" : "Scheduled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while saving the schedule:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSchedule()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlCommand updateCmd = new MySqlCommand(@"
                    UPDATE applications SET status = 'Interview'
                    WHERE application_id = @appId", conn);
                updateCmd.Parameters.AddWithValue("@appId", ApplicationId);
                updateCmd.ExecuteNonQuery();

                MySqlCommand histCmd = new MySqlCommand(@"
                    INSERT INTO application_status_history
                        (application_id, status, changed_at)
                    VALUES (@appId, 'Interview', NOW())", conn);
                histCmd.Parameters.AddWithValue("@appId", ApplicationId);
                histCmd.ExecuteNonQuery();

                MySqlCommand checkCmd = new MySqlCommand(@"
                    SELECT COUNT(*) FROM interviews
                    WHERE application_id = @appId", conn);
                checkCmd.Parameters.AddWithValue("@appId", ApplicationId);
                bool exists = Convert.ToInt64(checkCmd.ExecuteScalar()) > 0;

                if (exists)
                {
                    MySqlCommand updCmd = new MySqlCommand(@"
                        UPDATE interviews
                        SET interview_date = @date,
                            interview_time = @time,
                            interview_type = @type,
                            location_link  = @location,
                            interviewer    = @interviewer,
                            remarks        = @remarks
                        WHERE application_id = @appId", conn);
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
                    MySqlCommand insCmd = new MySqlCommand(@"
                        INSERT INTO interviews
                            (application_id, applicant_id,
                             interview_date, interview_time,
                             interview_type, location_link,
                             interviewer, remarks)
                        VALUES
                            (@appId, @applicantId,
                             @date, @time,
                             @type, @location,
                             @interviewer, @remarks)", conn);
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

                string actionVerb = _existingScheduleLoaded ? "Rescheduled" : "Scheduled";
                MySqlCommand noteCmd = new MySqlCommand(@"
                    INSERT INTO updates (applicant_id, update_message, created_at)
                    VALUES (@applicantId, @msg, NOW())", conn);
                noteCmd.Parameters.AddWithValue("@applicantId", ApplicantId);
                noteCmd.Parameters.AddWithValue("@msg",
                    $"[Interview {actionVerb}] " +
                    $"Date: {dtpDate.Value:MMMM dd, yyyy} " +
                    $"at {dtpTime.Value:hh:mm tt} | " +
                    $"Type: {cmbType.Text} | " +
                    $"Interviewer: {txtInterviewer.Text.Trim()} | " +
                    $"Location/Link: {txtLocationLink.Text.Trim()}");
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
