using System;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace HR_Project.HR_System
{
    public partial class Maintenance : Form
    {
        public string UserRole { get; set; } = "";
        public string UserName { get; set; } = "";

        private string connectionString =
            "server=127.0.0.1;port=3306;uid=root;pwd=031107Navarro;database=hr_db;";

        private static readonly (string table, string idCol, string nameCol, string label)[] Categories =
        {
            ("departments",      "department_id",    "department_name",    "Departments"),
            ("positions",        "position_id",      "position_name",      "Positions"),
            ("employment_types", "employment_id",    "employment_type",    "Employment Types"),
            ("requirement_types","requirement_id",   "requirement_name",   "Requirement Types"),
            ("interview_types",  "interview_type_id","interview_type_name","Interview Types"),
            ("assessment_types", "assessment_id",    "assessment_name",    "Assessment Types"),
        };

        private static readonly System.Collections.Generic.Dictionary<string, (string refTable, string refCol)> UsageMap
            = new System.Collections.Generic.Dictionary<string, (string, string)>
        {
            { "departments",      ("job_vacancies", "department")      },
            { "positions",        ("job_vacancies", "position")        },
            { "employment_types", ("job_vacancies", "employment_type") },
            { "requirement_types",("job_vacancies", "requirements")    },
        };

        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            if (UserRole != "Admin" && UserRole != "HR Manager")
            {
                MessageBox.Show(
                    "You do not have permission to access the Maintenance module.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            ApplyTheme();
            WireEvents();
            WireBackButton();
        }

        private void ApplyTheme()
        {
            UITheme.StyleForm(this);
            UITheme.StyleHeader(panelHeader, lblTitle);

            panelContent.BackColor = UITheme.BgPage;

            StyleCard(panelCategories);
            StyleCard(panelInput);
            StyleCard(panelGrid);

            UITheme.StyleSectionLabel(lblCategoriesTitle);
            UITheme.StyleSectionLabel(lblInputTitle);
            UITheme.StyleSectionLabel(lblGridTitle);

            lblCategoriesTitle.Font = UITheme.FontSection;
            lblInputTitle.Font = UITheme.FontSection;
            lblGridTitle.Font = UITheme.FontSection;

            StyleFieldLabel(lblCurrentCategory);
            StyleFieldLabel(lblValueName);

            UITheme.StyleTextBox(txtCurrentCategory);
            UITheme.StyleTextBox(txtValueInput);
            txtCurrentCategory.BackColor = UITheme.BgPage;

            UITheme.StylePrimaryButton(btnSaveEntry, UITheme.AccentGreen);
            StyleDangerButton(btnDeleteEntry);
            UITheme.StyleSecondaryButton(btnBack);

            lstCategories.BackColor = UITheme.BgPage;
            lstCategories.ForeColor = UITheme.TextPrimary;
            lstCategories.Font = UITheme.FontGrid;
            lstCategories.DrawMode = DrawMode.OwnerDrawFixed;
            lstCategories.ItemHeight = 36;
            lstCategories.DrawItem += LstCategories_DrawItem;

            UITheme.StyleGrid(dgvMaintenanceGrid);
        }

        private static void StyleCard(Panel p)
        {
            p.BackColor = Color.White;
            p.Paint += (s, e) =>
            {
                using (var pen = new System.Drawing.Pen(UITheme.BorderColor))
                    e.Graphics.DrawRectangle(pen,
                        new Rectangle(0, 0, p.Width - 1, p.Height - 1));
            };
        }

        private static void StyleFieldLabel(Label lbl)
        {
            lbl.Font = UITheme.FontGrid;
            lbl.ForeColor = UITheme.TextMuted;
            lbl.AutoSize = true;
        }

        private static void StyleDangerButton(Button btn)
        {
            var red = Color.FromArgb(255, 59, 48);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = red;
            btn.ForeColor = Color.White;
            btn.Font = UITheme.FontBtn;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(red, 0.1f);
        }

        private void LstCategories_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            Color bg = selected ? UITheme.AccentBlue
                                : (e.Index % 2 == 0 ? Color.White : UITheme.BgPage);
            Color fg = selected ? Color.White : UITheme.TextPrimary;

            e.Graphics.FillRectangle(new SolidBrush(bg), e.Bounds);

            string text = lstCategories.Items[e.Index].ToString();
            using (var brush = new SolidBrush(fg))
            using (var sf = new StringFormat { LineAlignment = StringAlignment.Center })
                e.Graphics.DrawString(text, UITheme.FontGrid, brush,
                    new RectangleF(e.Bounds.X + 12, e.Bounds.Y,
                                   e.Bounds.Width - 12, e.Bounds.Height), sf);
        }

        private void WireEvents()
        {
            lstCategories.SelectedIndexChanged += LstCategories_SelectedIndexChanged;
            btnSaveEntry.Click += BtnSaveEntry_Click;
            btnDeleteEntry.Click += BtnDeleteEntry_Click;

            dgvMaintenanceGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                txtValueInput.Text =
                    dgvMaintenanceGrid.Rows[e.RowIndex]
                        .Cells["colConValueName"].Value?.ToString() ?? "";
            };
        }

        private void WireBackButton()
        {
            btnBack.Click += (s, e) => this.Close();
        }

        private void LstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstCategories.SelectedIndex;
            if (idx < 0) return;

            txtCurrentCategory.Text = Categories[idx].label;
            txtValueInput.Clear();
            LoadGrid(idx);
        }

        private void LoadGrid(int idx)
        {
            var (table, idCol, nameCol, label) = Categories[idx];
            dgvMaintenanceGrid.Rows.Clear();
            dgvMaintenanceGrid.Columns["colConValueName"].HeaderText = label;

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"SELECT `{idCol}`, `{nameCol}` " +
                                 $"FROM `{table}` ORDER BY `{nameCol}`";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            dgvMaintenanceGrid.Rows.Add(reader[idCol], reader[nameCol]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load data:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveEntry_Click(object sender, EventArgs e)
        {
            int idx = lstCategories.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Please select a category first.",
                    "No Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string value = txtValueInput.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please enter a value / name.",
                    "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (table, _, nameCol, label) = Categories[idx];

            if (IsDuplicate(table, nameCol, value))
            {
                MessageBox.Show($"'{value}' already exists in {label}.",
                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"INSERT INTO `{table}` (`{nameCol}`) VALUES (@val)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@val", value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"'{value}' added to {label}.",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValueInput.Clear();
                LoadGrid(idx);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save entry:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteEntry_Click(object sender, EventArgs e)
        {
            int idx = lstCategories.SelectedIndex;
            if (idx < 0) return;

            if (dgvMaintenanceGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (table, idCol, _, label) = Categories[idx];
            int id = Convert.ToInt32(
                dgvMaintenanceGrid.SelectedRows[0].Cells["colID"].Value);
            string name = dgvMaintenanceGrid.SelectedRows[0]
                .Cells["colConValueName"].Value?.ToString() ?? "";

            if (MessageBox.Show(
                    $"Delete \"{name}\" from {label}?\n\nThis cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            if (UsageMap.TryGetValue(table, out var usage) &&
                IsValueInUse(usage.refTable, usage.refCol, name))
            {
                MessageBox.Show(
                    $"Cannot delete \"{name}\" — it is currently used in existing records.",
                    "In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"DELETE FROM `{table}` WHERE `{idCol}` = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                txtValueInput.Clear();
                LoadGrid(idx);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete entry:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDuplicate(string table, string nameCol, string value)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"SELECT COUNT(*) FROM `{table}` " +
                                 $"WHERE LOWER(`{nameCol}`) = LOWER(@val)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@val", value);
                        return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch { return false; }
        }

        private bool IsValueInUse(string refTable, string refCol, string value)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"SELECT COUNT(*) FROM `{refTable}` " +
                                 $"WHERE `{refCol}` = @val";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@val", value);
                        return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch { return false; }
        }
    }
}
