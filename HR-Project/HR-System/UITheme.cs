using System;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Project.HR_System
{
    public static class UITheme
    {
        public static readonly Color BgPage = Color.FromArgb(245, 247, 250);
        public static readonly Color BgHeader = Color.FromArgb(22, 22, 34);
        public static readonly Color BgNav = Color.FromArgb(30, 30, 46);
        public static readonly Color BgCard = Color.White;
        public static readonly Color BgGrid = Color.White;
        public static readonly Color AccentGreen = Color.FromArgb(52, 199, 89);
        public static readonly Color AccentBlue = Color.FromArgb(10, 132, 255);
        public static readonly Color NavActive = Color.FromArgb(52, 199, 89);
        public static readonly Color NavHover = Color.FromArgb(50, 50, 70);
        public static readonly Color TextPrimary = Color.FromArgb(30, 30, 30);
        public static readonly Color TextMuted = Color.FromArgb(130, 130, 150);
        public static readonly Color TextLight = Color.White;
        public static readonly Color BorderColor = Color.FromArgb(220, 220, 230);

        public static readonly Font FontTitle = new Font("Segoe UI", 13f, FontStyle.Bold);
        public static readonly Font FontNav = new Font("Segoe UI", 9f, FontStyle.Regular);
        public static readonly Font FontNavActive = new Font("Segoe UI", 9f, FontStyle.Bold);
        public static readonly Font FontCardNum = new Font("Segoe UI", 26f, FontStyle.Bold);
        public static readonly Font FontCardLabel = new Font("Segoe UI", 9f, FontStyle.Regular);
        public static readonly Font FontWelcome = new Font("Segoe UI", 14f, FontStyle.Bold);
        public static readonly Font FontGridHead = new Font("Segoe UI", 9f, FontStyle.Bold);
        public static readonly Font FontGrid = new Font("Segoe UI", 9f, FontStyle.Regular);
        public static readonly Font FontSection = new Font("Segoe UI", 10f, FontStyle.Bold);
        public static readonly Font FontBtn = new Font("Segoe UI", 9f, FontStyle.Regular);

        public static void StyleForm(Form form)
        {
            form.BackColor = BgPage;
            form.BackgroundImage = null;
            form.BackgroundImageLayout = ImageLayout.None;
        }

        public static void StyleHeader(Panel panel, Label titleLabel)
        {
            panel.BackColor = BgHeader;
            titleLabel.ForeColor = TextLight;
            titleLabel.Font = FontTitle;
        }

        public static void StyleNav(Panel panel)
        {
            panel.BackColor = BgNav;
        }

        public static void StyleNavButton(Button btn, bool isActive = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.Cursor = Cursors.Hand;

            btn.ForeColor = TextLight;

            if (isActive)
            {
                StyleActiveNavigationButton(btn);
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = TextLight;
                btn.Font = FontNav;

                btn.FlatAppearance.MouseOverBackColor = NavHover;
                btn.FlatAppearance.MouseDownBackColor = NavHover;
            }
        }

        public static void StyleHeaderButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 80);
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(255, 80, 80);
            btn.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleLogoutButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 80);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 80, 80);
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(255, 80, 80);
            btn.Font = FontBtn;
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleStatCard(Panel panel, Label countLabel,
            Label titleLabel, Color accentColor)
        {
            panel.BackColor = BgCard;
            panel.Padding = new Padding(16);

            panel.Paint += (s, e) =>
            {
                using (var brush = new SolidBrush(accentColor))
                    e.Graphics.FillRectangle(brush,
                        new Rectangle(0, 0, 4, panel.Height));
            };

            countLabel.Font = FontCardNum;
            countLabel.ForeColor = accentColor;
            countLabel.AutoSize = true;

            titleLabel.Font = FontCardLabel;
            titleLabel.ForeColor = TextMuted;
            titleLabel.AutoSize = true;
        }

        public static void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = BgGrid;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = BorderColor;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.DefaultCellStyle.Font = FontGrid;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.BackColor = BgGrid;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 245, 255);
            dgv.DefaultCellStyle.SelectionForeColor = TextPrimary;
            dgv.DefaultCellStyle.Padding = new Padding(4, 6, 4, 6);

            dgv.ColumnHeadersDefaultCellStyle.Font = FontGridHead;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextMuted;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = BgGrid;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 8, 4, 8);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 36;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowTemplate.Height = 36;
        }

        public static void StyleSectionLabel(Label lbl)
        {
            lbl.Font = FontSection;
            lbl.ForeColor = TextPrimary;
            lbl.AutoSize = true;
        }

        public static void StylePrimaryButton(Button btn, Color? color = null)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = color ?? AccentBlue;
            btn.ForeColor = TextLight;
            btn.Font = FontBtn;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(color ?? AccentBlue, 0.1f);
        }

        public static void StyleSecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.BackColor = BgCard;
            btn.ForeColor = TextPrimary;
            btn.Font = FontBtn;
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = FontGrid;
            txt.BackColor = BgCard;
            txt.ForeColor = TextPrimary;
        }

        public static void StyleComboBox(ComboBox cmb)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.Font = FontGrid;
            cmb.BackColor = BgCard;
            cmb.ForeColor = TextPrimary;
        }

        public static void StyleActiveNavigationButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.BackColor = Color.FromArgb(50, 50, 70);
            btn.ForeColor = Color.White;
            btn.Font = FontNavActive;

            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 65, 90);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 75, 100);
        }
    }
}
