        using System;
        using System.IO;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;
        using System.Windows.Forms;
        using MySqlConnector;

        namespace HR_Project
        {
            public partial class profilepage : Form
            {
            private bool _hrViewMode = false;
            private int _applicationId = -1;

            private DataTable workExperienceTable = new DataTable();
                private bool editMode = false;

                private byte[] profileImageBytes = null;

                public int applicantId;

                string connectionString = "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        public profilepage(int applicantId)
        {
            InitializeComponent();

            workExperienceTable.Columns.Add("company_name");
            workExperienceTable.Columns.Add("position_title");
            workExperienceTable.Columns.Add("employment_type");
            workExperienceTable.Columns.Add(
                "start_date",
                typeof(DateTime));
            workExperienceTable.Columns.Add(
                "end_date",
                typeof(DateTime));
            workExperienceTable.Columns.Add("currently_working");
            workExperienceTable.Columns.Add("job_description");

            dgvWorkExperience.DataSource = workExperienceTable;
            this.applicantId = applicantId;

            this.Text = "My Profile";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            SetEditMode(false);

            btnProfilePageEdit.Text = "Edit";

            btnProfilePageEdit.BackColor = Color.RoyalBlue;
            btnProfilePageEdit.ForeColor = Color.White;
            btnProfilePageEdit.FlatStyle = FlatStyle.Flat;
            btnProfilePageEdit.FlatAppearance.BorderSize = 0;
            btnProfilePageEdit.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        public profilepage(int applicantId, bool hrViewMode)
        {
            InitializeComponent();

            workExperienceTable.Columns.Add("company_name");
            workExperienceTable.Columns.Add("position_title");
            workExperienceTable.Columns.Add("employment_type");
            workExperienceTable.Columns.Add("start_date", typeof(DateTime));
            workExperienceTable.Columns.Add("end_date", typeof(DateTime));
            workExperienceTable.Columns.Add("currently_working");
            workExperienceTable.Columns.Add("job_description");

            dgvWorkExperience.DataSource = workExperienceTable;
            this.applicantId = applicantId;
            _hrViewMode = hrViewMode;

            this.Text = "Applicant Profile (View Only)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            SetEditMode(false);

            if (hrViewMode)
                SetHRViewMode();
        }

        public profilepage(int applicantId, int applicationId, bool hrViewMode)
        {
            InitializeComponent();

            workExperienceTable.Columns.Add("company_name");
            workExperienceTable.Columns.Add("position_title");
            workExperienceTable.Columns.Add("employment_type");
            workExperienceTable.Columns.Add("start_date", typeof(DateTime));
            workExperienceTable.Columns.Add("end_date", typeof(DateTime));
            workExperienceTable.Columns.Add("currently_working");
            workExperienceTable.Columns.Add("job_description");

            dgvWorkExperience.DataSource = workExperienceTable;
            this.applicantId = applicantId;
            _applicationId = applicationId;
            _hrViewMode = hrViewMode;

            this.Text = "Applicant Profile (View Only)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            SetEditMode(false);

            if (hrViewMode)
                SetHRViewMode();
        }

        private void SetHRViewMode()
        {
            btnProfilePageEdit.Visible = false;
            btnProfilePageLogout.Visible = false;
            btnProfilePageChangePass.Visible = false;
            btnProfilePageUploadPhoto.Visible = false;
            btnProfilePageWorkExperience.Visible = false;
            btnWorkExpRemove.Visible = false;
            btnProfilePageSkillsAdd.Visible = false;
            btnProfilePageSkillsRemove.Visible = false;

            btnProfilePageDashboard.Visible = false;
            btnProfilePageDocuments.Visible = false;
            btnProfilePageJobVacancies.Visible = false;
            btnProfilePageMyApplication.Visible = false;

            Button btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Size = new Size(100, 35);
            btnClose.Location = new Point(10, 10);
            btnClose.BackColor = Color.SteelBlue;
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
            btnClose.BringToFront();
        }

        private void LoadProfileSnapshot(int applicationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT s.*
            FROM application_profile_snapshots s
            WHERE s.application_id = @appId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appId", applicationId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtBoxProfilePageFirstName.Text = reader["first_name"].ToString();
                        txtBoxProfilePageLastName.Text = reader["last_name"].ToString();
                        txtBoxProfilePageMiddleName.Text = reader["middle_name"].ToString();
                        txtBoxProfilePageEmail.Text = reader["email"].ToString();
                        txtBoxProfilePageContact.Text = reader["contact"].ToString();

                        if (reader["birth_date"] != DBNull.Value)
                            dtpProfilePageDOB.Value = Convert.ToDateTime(reader["birth_date"]);

                        if (reader["gender"].ToString() == "Male")
                            radbtnProfilePageMale.Checked = true;
                        else
                            radbtnProfilePageFemale.Checked = true;

                        txtBoxProfilePageAltContact.Text = reader["alternate_phone"].ToString();
                        txtBoxProfilePageCurrentAddress.Text = reader["address"].ToString();
                        txtBoxProfilePageState.Text = reader["province"].ToString();
                        txtBoxProfilePagePostCode.Text = reader["postal_code"].ToString();

                        cmbBoxProfilePageDegree.Text = reader["highest_degree"].ToString();
                        txtBoxProfilePageInstitution.Text = reader["institution_name"].ToString();
                        txtBoxProfilePageMajor.Text = reader["field_of_study"].ToString();

                        if (reader["graduation_date"] != DBNull.Value)
                            dtpProfilePageGraduationYear.Value = Convert.ToDateTime(reader["graduation_date"]);

                        if (reader["profile_picture"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["profile_picture"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                                picBoxProfilePagepfp.Image = Image.FromStream(ms);
                        }

                        long snapshotId = Convert.ToInt64(reader["snapshot_id"]);
                        reader.Close();

                        lstBoxProfilePageSkills.Items.Clear();
                        string skillQuery = @"
                        SELECT skill_name FROM snapshot_skills
                        WHERE snapshot_id = @snapId";
                        MySqlCommand skillCmd = new MySqlCommand(skillQuery, conn);
                        skillCmd.Parameters.AddWithValue("@snapId", snapshotId);
                        using (MySqlDataReader sr = skillCmd.ExecuteReader())
                        {
                            while (sr.Read())
                                lstBoxProfilePageSkills.Items.Add(sr["skill_name"].ToString());
                        }

                        workExperienceTable.Rows.Clear();
                        string workQuery = @"
                        SELECT company_name, position_title, employment_type,
                               start_date, end_date, currently_working, job_description
                        FROM snapshot_work_experience
                        WHERE snapshot_id = @snapId";
                        MySqlCommand workCmd = new MySqlCommand(workQuery, conn);
                        workCmd.Parameters.AddWithValue("@snapId", snapshotId);
                        using (MySqlDataReader wr = workCmd.ExecuteReader())
                        {
                            while (wr.Read())
                            {
                                workExperienceTable.Rows.Add(
                                    wr["company_name"],
                                    wr["position_title"],
                                    wr["employment_type"],
                                    wr["start_date"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDateTime(wr["start_date"]),
                                    wr["end_date"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDateTime(wr["end_date"]),
                                    wr["currently_working"],
                                    wr["job_description"]
                                );
                            }
                        }
                    }
                    else
                    {
                       
                        reader.Close();
                        MessageBox.Show(
                            "No snapshot found for this application.\n" +
                            "Showing current live profile instead.",
                            "Snapshot Not Available",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadProfile();
                        LoadApplicantPhoto();
                        LoadSkills();
                        LoadWorkExperience();
                    }
                }
            }
        }

        private void SetEditMode(bool editing)
                {
                    txtBoxProfilePageFirstName.ReadOnly = !editing;
                    txtBoxProfilePageLastName.ReadOnly = !editing;
                    txtBoxProfilePageMiddleName.ReadOnly = !editing;

                    txtBoxProfilePageEmail.ReadOnly = !editing;

                    txtBoxProfilePageContact.ReadOnly = !editing;
                    txtBoxProfilePageAltContact.ReadOnly = !editing;

                    txtBoxProfilePageCurrentAddress.ReadOnly = !editing;
                    txtBoxProfilePageState.ReadOnly = !editing;
                    txtBoxProfilePagePostCode.ReadOnly = !editing;

                    txtBoxProfilePageInstitution.ReadOnly = !editing;
                    txtBoxProfilePageMajor.ReadOnly = !editing;

                    cmbBoxProfilePageDegree.Enabled = editing;

                    dtpProfilePageDOB.Enabled = editing;
                    dtpProfilePageGraduationYear.Enabled = editing;

                    radbtnProfilePageMale.Enabled = editing;
                    radbtnProfilePageFemale.Enabled = editing;

                    txtBoxProfilePageSkills.ReadOnly = !editing;
                    btnProfilePageSkillsAdd.Enabled = editing;
                    btnProfilePageSkillsRemove.Enabled = editing;
                    btnProfilePageUploadPhoto.Enabled = editing;
                    btnProfilePageChangePass.Enabled = editing;

                    btnProfilePageWorkExperience.Enabled = editing;
                    btnWorkExpRemove.Enabled = editing;
                }

                private bool ValidateProfile()
                {
                    MessageBox.Show("Validation Running");

                    bool isValid = true;

                    errorProviderProfilePage.Clear();

                    // First Name
                    if (string.IsNullOrWhiteSpace(txtBoxProfilePageFirstName.Text))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageFirstName,
                            "First Name is required."
                        );
                        isValid = false;
                    }

                    // Last Name
                    if (string.IsNullOrWhiteSpace(txtBoxProfilePageLastName.Text))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageLastName,
                            "Last Name is required."
                        );
                        isValid = false;
                    }

                    // Email
                    if (string.IsNullOrWhiteSpace(txtBoxProfilePageEmail.Text))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageEmail,
                            "Email is required."
                        );
                        isValid = false;
                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(
                        txtBoxProfilePageEmail.Text.Trim(),
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageEmail,
                            "Invalid Email Address."
                        );
                        isValid = false;
                    }

                    // Contact Number
                    if (!System.Text.RegularExpressions.Regex.IsMatch(
                        txtBoxProfilePageContact.Text,
                        @"^09\d{9}$"))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageContact,
                            "Enter a valid 11-digit mobile number."
                        );
                        isValid = false;
                    }

                    // Alternate Number
                    if (!string.IsNullOrWhiteSpace(txtBoxProfilePageAltContact.Text))
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(
                            txtBoxProfilePageAltContact.Text,
                            @"^09\d{9}$"))
                        {
                            errorProviderProfilePage.SetError(
                                txtBoxProfilePageAltContact,
                                "Enter a valid 11-digit mobile number."
                            );
                            isValid = false;
                        }
                    }

                    // Address
                    if (string.IsNullOrWhiteSpace(txtBoxProfilePageCurrentAddress.Text))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageCurrentAddress,
                            "Address is required."
                        );
                        isValid = false;
                    }

                    // Degree
                    if (string.IsNullOrWhiteSpace(cmbBoxProfilePageDegree.Text))
                    {
                        errorProviderProfilePage.SetError(
                            cmbBoxProfilePageDegree,
                            "Select a degree."
                        );
                        isValid = false;
                    }

                    // Institution
                    if (string.IsNullOrWhiteSpace(txtBoxProfilePageInstitution.Text))
                    {
                        errorProviderProfilePage.SetError(
                            txtBoxProfilePageInstitution,
                            "Institution is required."
                        );
                        isValid = false;
                    }

                    // DOB
                    if (dtpProfilePageDOB.Value > DateTime.Today)
                    {
                        errorProviderProfilePage.SetError(
                            dtpProfilePageDOB,
                            "Birth date cannot be in the future."
                        );

                        isValid = false;
                    }

                    int age =
                    DateTime.Today.Year -
                    dtpProfilePageDOB.Value.Year;

                    if (dtpProfilePageDOB.Value.Date >
                        DateTime.Today.AddYears(-age))
                    {
                        age--;
                    }

                    if (age < 18)
                    {
                        errorProviderProfilePage.SetError(
                            dtpProfilePageDOB,
                            "Applicant must be at least 18 years old."
                        );

                        isValid = false;
                    }

                    // Profile Picture
                    OpenFileDialog ofd = new OpenFileDialog();

                    ofd.Filter =
                        "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    return isValid;
                }

                private void SaveProfile()
                {
                    using (MySqlConnection conn =
                        new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string gender =
                            radbtnProfilePageMale.Checked
                            ? "Male"
                            : "Female";

                        string query = @"
                        UPDATE applicants
                        SET
                            first_name=@fn,
                            last_name=@ln,
                            middle_name=@mn,
                            email=@em,
                            contact=@ct,
                            birth_date=@bd

                            WHERE id=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@fn",
                            txtBoxProfilePageFirstName.Text);

                        cmd.Parameters.AddWithValue("@ln",
                            txtBoxProfilePageLastName.Text);

                        cmd.Parameters.AddWithValue("@mn",
                            txtBoxProfilePageMiddleName.Text);

                        cmd.Parameters.AddWithValue("@em",
                            txtBoxProfilePageEmail.Text);

                        cmd.Parameters.AddWithValue("@id",
                            applicantId);

                        cmd.Parameters.AddWithValue("@ct",
                            txtBoxProfilePageContact.Text);

                        cmd.Parameters.AddWithValue("@bd",
                            dtpProfilePageDOB.Value.Date);

                        cmd.ExecuteNonQuery();

                        string profileQuery = @"
                        INSERT INTO applicant_profiles
                        (
                            applicant_id,
                            gender,
                            alternate_phone,
                            address,
                            province,
                            postal_code,
                            profile_picture
                        )
                        VALUES
                        (
                            @id,
                            @gender,
                            @altphone,
                            @address,
                            @province,
                            @postcode,
                            @pic
                        )
                        ON DUPLICATE KEY UPDATE

                            gender=@gender,
                            alternate_phone=@altphone,
                            address=@address,
                            province=@province,
                            postal_code=@postcode,

                            profile_picture =
                            CASE
                            WHEN @pic IS NULL
                            THEN profile_picture
                            ELSE @pic
                        END";

                            MySqlCommand cmd2 =
                                new MySqlCommand(profileQuery, conn);

                            cmd2.Parameters.AddWithValue("@id",
                                applicantId);

                            cmd2.Parameters.AddWithValue("@gender",
                                gender);

                            cmd2.Parameters.AddWithValue("@altphone",
                                txtBoxProfilePageAltContact.Text);

                            cmd2.Parameters.AddWithValue("@address",
                                txtBoxProfilePageCurrentAddress.Text);

                            cmd2.Parameters.AddWithValue("@province",
                                txtBoxProfilePageState.Text);

                            cmd2.Parameters.AddWithValue("@postcode",
                                txtBoxProfilePagePostCode.Text);

                        if (profileImageBytes == null)
                        {
                            cmd2.Parameters.AddWithValue("@pic", DBNull.Value);
                        }
                        else
                        {
                            cmd2.Parameters.AddWithValue("@pic", profileImageBytes);
                        }

                        cmd2.ExecuteNonQuery();

                        string eduQuery = @"
                        INSERT INTO education
                        (
                            applicant_id,
                            highest_degree,
                            institution_name,
                            field_of_study,
                            graduation_date
                        )
                        VALUES
                        (
                            @id,
                            @degree,
                            @institution,
                            @major,
                            @grad
                        )
                        ON DUPLICATE KEY UPDATE

                        highest_degree = @degree,
                        institution_name = @institution,
                        field_of_study = @major,
                        graduation_date = @grad";

                        MySqlCommand edu =
                            new MySqlCommand(eduQuery, conn);

                        edu.Parameters.AddWithValue("@id",
                            applicantId);

                        edu.Parameters.AddWithValue("@degree",
                            cmbBoxProfilePageDegree.Text);

                        edu.Parameters.AddWithValue("@institution",
                            txtBoxProfilePageInstitution.Text);

                        edu.Parameters.AddWithValue("@major",
                            txtBoxProfilePageMajor.Text);

                        edu.Parameters.AddWithValue("@grad",
                            dtpProfilePageGraduationYear.Value);

                        edu.ExecuteNonQuery();
                        SaveSkills();
                        SaveWorkExperience();
            }
                }

                private void LoadSkills()
                {
                    lstBoxProfilePageSkills.Items.Clear();

                    using (MySqlConnection conn =
                        new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query =
                        @"SELECT skill_name
                        FROM skills
                        WHERE applicant_id=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", applicantId);

                        MySqlDataReader reader =
                            cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            lstBoxProfilePageSkills.Items.Add(
                                reader["skill_name"].ToString());
                        }

                        reader.Close();
                    }
                }

                private void SaveSkills()
                {
                    using (MySqlConnection conn =
                        new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string deleteQuery =
                        @"DELETE FROM skills
                        WHERE applicant_id=@id";

                        MySqlCommand deleteCmd =
                            new MySqlCommand(deleteQuery, conn);

                        deleteCmd.Parameters.AddWithValue(
                            "@id",
                            applicantId);

                        deleteCmd.ExecuteNonQuery();

                        foreach (var item in lstBoxProfilePageSkills.Items)
                        {
                            string insertQuery =
                            @"INSERT INTO skills
                            (applicant_id, skill_name)
                            VALUES
                            (@id, @skill)";

                            MySqlCommand insertCmd =
                                new MySqlCommand(insertQuery, conn);

                            insertCmd.Parameters.AddWithValue(
                                "@id",
                                applicantId);

                            insertCmd.Parameters.AddWithValue(
                                "@skill",
                                item.ToString());

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                private void LoadApplicantPhoto()
                {
                    using (MySqlConnection conn =
                new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query =
                        @"SELECT profile_picture
                        FROM applicant_profiles
                        WHERE applicant_id=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", applicantId);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            profileImageBytes = (byte[])result;

                            using (MemoryStream ms =
                                new MemoryStream(profileImageBytes))
                            {
                                picBoxProfilePagepfp.Image =
                                    Image.FromStream(ms);
                            }
                        }
                    }
                }

                private void LoadProfile()
                {
                    using (MySqlConnection conn =
                        new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"
                        SELECT
                            a.first_name,
                            a.last_name,
                            a.middle_name,
                            a.email,
                            a.birth_date,
                            a.contact,
                            ap.gender,
                            ap.alternate_phone,
                            ap.address,
                            ap.province,
                            ap.postal_code,
                            ap.profile_picture
                        FROM applicants a
                        LEFT JOIN applicant_profiles ap
                            ON a.id = ap.applicant_id
                        WHERE a.id = @id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", applicantId);

                        MySqlDataReader reader =
                            cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtBoxProfilePageFirstName.Text =
                                reader["first_name"].ToString();

                            txtBoxProfilePageLastName.Text =
                                reader["last_name"].ToString();

                            txtBoxProfilePageMiddleName.Text =
                                reader["middle_name"].ToString();

                            txtBoxProfilePageEmail.Text =
                                reader["email"].ToString();

                            txtBoxProfilePageContact.Text =
                                reader["contact"].ToString();

                            txtBoxProfilePageAltContact.Text =
                                reader["alternate_phone"].ToString();

                            txtBoxProfilePageCurrentAddress.Text =
                                reader["address"].ToString();

                            txtBoxProfilePageState.Text =
                                reader["province"].ToString();

                            txtBoxProfilePagePostCode.Text =
                                reader["postal_code"].ToString();

                            if (reader["birth_date"] != DBNull.Value)
                            {
                                dtpProfilePageDOB.Value =
                                    Convert.ToDateTime(reader["birth_date"]);
                            }

                            string gender =
                                reader["gender"].ToString();

                            if (gender == "Male")
                                radbtnProfilePageMale.Checked = true;

                            if (gender == "Female")
                                radbtnProfilePageFemale.Checked = true;

                            if (reader["profile_picture"] != DBNull.Value)
                            {
                                byte[] imgBytes =
                                    (byte[])reader["profile_picture"];

                                using (MemoryStream ms =
                                    new MemoryStream(imgBytes))
                                {
                                    picBoxProfilePagepfp.Image =
                                        Image.FromStream(ms);
                                }

                                profileImageBytes = imgBytes;
                            }
                        }

                        reader.Close();
                    }

                    LoadEducation();
                    LoadSkills();
                }

                private void LoadEducation()
                {
                    using (MySqlConnection conn =
                        new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query =
                        @"SELECT * FROM education
                        WHERE applicant_id=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id",
                            applicantId);

                        MySqlDataReader reader =
                            cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            cmbBoxProfilePageDegree.Text =
                                reader["highest_degree"].ToString();

                            txtBoxProfilePageInstitution.Text =
                                reader["institution_name"].ToString();

                            txtBoxProfilePageMajor.Text =
                                reader["field_of_study"].ToString();

                            if (reader["graduation_date"] != DBNull.Value)
                            {
                                dtpProfilePageGraduationYear.Value =
                                    Convert.ToDateTime(
                                    reader["graduation_date"]);
                            }
                        }

                        reader.Close();
                    }
                }

                private void LoadWorkExperience()
                {
                    using (MySqlConnection conn =
                        new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query =
                        @"SELECT
                            id,
                            company_name,
                            position_title,
                            employment_type,
                            start_date,
                            end_date,
                            currently_working,
                            job_description
                        FROM applicant_work_experience
                        WHERE applicant_id=@id";

                MySqlDataAdapter da =
                            new MySqlDataAdapter(query, conn);

                        da.SelectCommand.Parameters.AddWithValue(
                            "@id",
                            applicantId);

                        workExperienceTable.Clear();

                        da.Fill(workExperienceTable);

                        dgvWorkExperience.DataSource = workExperienceTable;
                    }
                }

        private void SaveWorkExperience()
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string deleteQuery =
                @"DELETE FROM applicant_work_experience
                  WHERE applicant_id=@id";

                MySqlCommand deleteCmd =
                    new MySqlCommand(deleteQuery, conn);

                deleteCmd.Parameters.AddWithValue(
                    "@id",
                    applicantId);

                deleteCmd.ExecuteNonQuery();

                // Insert current rows
                foreach (DataRow row in workExperienceTable.Rows)
                {
                    string insertQuery =
                    @"INSERT INTO applicant_work_experience
                    (
                        applicant_id,
                        company_name,
                        position_title,
                        employment_type,
                        start_date,
                        end_date,
                        currently_working,
                        job_description
                    )
                    VALUES
                    (
                        @id,
                        @company,
                        @position,
                        @employment,
                        @start,
                        @end,
                        @current,
                        @description    
                    )";

                    MySqlCommand insertCmd =
                        new MySqlCommand(insertQuery, conn);

                    insertCmd.Parameters.AddWithValue(
                        "@id",
                        applicantId);

                    insertCmd.Parameters.AddWithValue(
                        "@company",
                        row["company_name"]);

                    insertCmd.Parameters.AddWithValue(
                        "@position",
                        row["position_title"]);

                    insertCmd.Parameters.AddWithValue(
                        "@employment",
                        row["employment_type"]);

                    DateTime startDate =
                        Convert.ToDateTime(row["start_date"]);

                    insertCmd.Parameters.AddWithValue(
                        "@start",
                        startDate.Date);

                    if (row["end_date"] == DBNull.Value ||
                        string.IsNullOrWhiteSpace(row["end_date"].ToString()))
                    {
                        insertCmd.Parameters.AddWithValue(
                            "@end",
                            DBNull.Value);
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue(
                            "@end",
                            Convert.ToDateTime(row["end_date"]).Date);
                    }

                    insertCmd.Parameters.AddWithValue(
                        "@current",
                        Convert.ToBoolean(row["currently_working"]) ? 1 : 0);

                    insertCmd.Parameters.AddWithValue(
                        "@description",
                        row["job_description"]);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        private void LettersOnly(KeyPressEventArgs e)
                {
                    if (!char.IsControl(e.KeyChar) &&
                        !char.IsLetter(e.KeyChar) &&
                        e.KeyChar != ' ')
                    {
                        e.Handled = true;
                    }
                }

                private void btnMyApllication_Click(object sender, EventArgs e)
                {

                }

                private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
                {

                }

                private void btnStatus_Click(object sender, EventArgs e)
                {

                }

                private void label2_Click(object sender, EventArgs e)
                {

                }

                private void label2_Click_1(object sender, EventArgs e)
                {

                }

                private void label2_Click_2(object sender, EventArgs e)
                {

                }

                private void button1_Click(object sender, EventArgs e)
                {
                    OpenFileDialog ofd = new OpenFileDialog();

                    ofd.Filter =
                        "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picBoxProfilePagepfp.Image =
                            Image.FromFile(ofd.FileName);

                        profileImageBytes =
                            File.ReadAllBytes(ofd.FileName);
                    }
                }

                private void NumbersOnly(KeyPressEventArgs e)
                {
                    if (!char.IsControl(e.KeyChar) &&
                        !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

                private void label2_Click_3(object sender, EventArgs e)
                {

                }

                private void lblAltNumber_Click(object sender, EventArgs e)
                {

                }

                private void label2_Click_4(object sender, EventArgs e)
                {

                }

                private void lblTitle_Click(object sender, EventArgs e)
                {

                }

                private void label3_Click(object sender, EventArgs e)
                {

                }

                private void btnProfilePageClose_Click(object sender, EventArgs e)
                {
                    Application.Exit();
                }

                private void profilepage_Load(object sender, EventArgs e)
                {
                    if (_hrViewMode && _applicationId > 0)
                    {
                        LoadProfileSnapshot(_applicationId);
                    }
                    else
                    {
                        LoadProfile();
                        LoadApplicantPhoto();
                        LoadSkills();
                        LoadWorkExperience();
                    }
                }

                private void btnProfilePageEdit_Click(object sender, EventArgs e)
                {
                    if (!editMode)
                    {
                        editMode = true;

                        SetEditMode(true);

                        btnProfilePageEdit.Text = "Update";
                    }
                    else
                    {
                        if (!ValidateProfile())
                            return;

                        SaveProfile();

                        editMode = false;

                        SetEditMode(false);

                        btnProfilePageEdit.Text = "Edit";

                        MessageBox.Show("Profile Updated Successfully.");
                    }

                }

                private void txtBoxProfilePageState_TextChanged(object sender, EventArgs e)
                {

                }

                private void tpSkills_Click(object sender, EventArgs e)
                {

                }

                private void btnProfilePageSkillsAdd_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrWhiteSpace(txtBoxProfilePageSkills.Text))
                    {
                        MessageBox.Show("Enter a skill.");
                        return;
                    }

                    lstBoxProfilePageSkills.Items.Add(txtBoxProfilePageSkills.Text.Trim());

                    txtBoxProfilePageSkills.Clear();
                }

                private void btnProfilePageSkillsRemove_Click(object sender, EventArgs e)
                {
                    if (lstBoxProfilePageSkills.SelectedIndex >= 0)
                    {
                        lstBoxProfilePageSkills.Items.RemoveAt(
                            lstBoxProfilePageSkills.SelectedIndex);
                    }
                }

                private void tabPage2_Click(object sender, EventArgs e)
                {

                }

                private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

                private void btnProfilePageDashboard_Click(object sender, EventArgs e)
                {
                    Dashboard dashboard = new Dashboard();

                    dashboard.ApplicantId = applicantId;

                    dashboard.Show();

                    this.Hide();
                }

                private void txtBoxProfilePageFirstName_KeyPress(object sender, KeyPressEventArgs e)
                {
                    LettersOnly(e);
                }

                private void txtBoxProfilePageLastName_KeyPress(object sender, KeyPressEventArgs e)
                {
                    LettersOnly(e);
                }

                private void txtBoxProfilePageMiddleName_KeyPress(object sender, KeyPressEventArgs e)
                {
                    LettersOnly(e);
                }

                private void txtBoxProfilePageContact_KeyPress(object sender, KeyPressEventArgs e)
                {
                    NumbersOnly(e);
                }

                private void txtBoxProfilePageAltContact_KeyPress(object sender, KeyPressEventArgs e)
                {
                    NumbersOnly(e);
                }

                private void btnProfilePageWorkExperience_Click(object sender, EventArgs e)
                {
                    WorkExperience work = new WorkExperience();

                    if (work.ShowDialog() == DialogResult.OK)
                    {
                        using (MySqlConnection conn =
                            new MySqlConnection(connectionString))
                        {
                            conn.Open();

                            string query = @"
                            INSERT INTO applicant_work_experience
                            (
                                applicant_id,
                                company_name,
                                position_title,
                                employment_type,
                                start_date,
                                end_date,
                                currently_working,
                                job_description
                            )
                            VALUES
                            (
                                @id,
                                @company,
                                @position,
                                @employment,
                                @start,
                                @end,
                                @current,
                                @description
                            )";

                            MySqlCommand cmd =
                                new MySqlCommand(query, conn);

                            cmd.Parameters.AddWithValue("@id", applicantId);
                            cmd.Parameters.AddWithValue("@company", work.WorkCompanyName);
                            cmd.Parameters.AddWithValue("@position", work.PositionTitle);
                            cmd.Parameters.AddWithValue("@employment", work.EmploymentType);
                            cmd.Parameters.AddWithValue("@start", work.StartDate);
                            cmd.Parameters.AddWithValue("@end", work.EndDate);
                            cmd.Parameters.AddWithValue(
                                "@current",
                                work.CurrentlyWorking ? 1 : 0);
                            cmd.Parameters.AddWithValue("@description", work.JobDescription);

                            cmd.ExecuteNonQuery();
                        }

                        LoadWorkExperience();
                    }
                }

        private void btnWorkExpRemove_Click(object sender, EventArgs e)
        {
            if (dgvWorkExperience.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a work experience to remove.");
                return;
            }

            int workId = Convert.ToInt32(
                dgvWorkExperience.SelectedRows[0].Cells["id"].Value);

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                "DELETE FROM applicant_work_experience WHERE id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", workId);

                cmd.ExecuteNonQuery();
            }

            LoadWorkExperience();

            MessageBox.Show("Work experience removed successfully.");
        }

        private void btnProfilePageDocuments_Click(object sender, EventArgs e)
        {
            DocumentPage doc = new DocumentPage();

            doc.ApplicantId = applicantId;

            doc.Show();
            this.Hide();

            panelProfilePageNavigation.BringToFront();
        }

        private void btnProfilePageChangePass_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();

            form.ApplicantId = this.applicantId;        

            form.ShowDialog();
        }

        private void btnProfilePageJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacancies job = new JobVacancies();

            job.applicantId = applicantId;

            job.Show();

            this.Hide();

            panelProfilePageNavigation.BringToFront();
        }

        private void btnProfilePageMyApplication_Click(object sender, EventArgs e)
        {
            ApplicantPage1 app =
               new ApplicantPage1();

            app.ApplicantId = applicantId;

            app.Show();

            this.Hide();
        }

        private void btnProfilePageLogout_Click(object sender, EventArgs e)
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

        private void btnProfilePageStatusTracking_Click(object sender, EventArgs e)
        {
            StatusTracking st = new StatusTracking(applicantId);
            st.Show();
            this.Hide();
        }
    }
        }
