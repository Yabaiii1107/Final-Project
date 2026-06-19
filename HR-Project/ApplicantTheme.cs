using System.Drawing;
using System.Windows.Forms;
using HR_Project.HR_System; 

namespace HR_Project
{
    public static class ApplicantTheme
    {
        private static readonly string[] NavButtonNames = new[]
        {
            "btnDashboard", "btnMyProfile", "btnJobVacancies",
            "btnMyApplication", "btnDocuments", "btnStatusTracking",

            "btnMyDocumentsDashboard", "btnMyApplicationMyProfile",
            "btnMyApplicationsJobVacancies", "btnMyDocumentsMyApplication",
            "btnMyDocumentsDocuments", "btnMyDocumentsStatusTracking",
 
            "btnMyDocumentsMyProfile", "btnMyDocumentsJobVacancies",
  
            "btnProfilePageDashboard", "btnProfilePageMyProfile",
            "btnMyApplication", "btnDocuments", "btnStatusTracking",

            "btnProfilePageDashboard", "btnProfilePageMyProfile",
            "btnProfilePageJobVacancies", "btnProfilePageMyApplication",
            "btnProfilePageDocuments", "btnProfilePageStatusTracking",
        };

        private static readonly string[] CloseButtonNames = new[]
        {
            "btnDashboardClose", "btnProfilePageClose", "btnProfilePageClose"
        };

        private static readonly string[] LogoutButtonNames = new[]
        {
            "btnLogout", "btnMyDocumentsLogout", "btnProfilePageLogout"
        };

        private static readonly string[] PrimaryButtonNames = new[]
        {
            "btnApply", "btnSearchButton", "btnSubmitEvaluation",
            "btnMyDocumentsUploadFile", "btnMyDocumentsBrowse"
        };

        private static readonly string[] DangerButtonNames = new[]
        {
            "btnCancelApplication"
        };

        public static void Apply(Form form, string activeButtonName = null)
        {
            UITheme.StyleForm(form);
            ApplyRecursive(form.Controls, activeButtonName);
            StyleHeaderPanel(form);
            StyleNavPanel(form, activeButtonName);
        }
        
        private static void ApplyRecursive(
            Control.ControlCollection controls, string activeButtonName)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    string name = btn.Name;

                    if (IsMatch(name, CloseButtonNames))
                        UITheme.StyleHeaderButton(btn);

                    else if (IsMatch(name, LogoutButtonNames))
                        UITheme.StyleLogoutButton(btn);

                    else if (IsMatch(name, NavButtonNames))
                    {
                        if (name == activeButtonName)
                            UITheme.StyleActiveNavigationButton(btn);
                        else
                            UITheme.StyleNavButton(btn);
                    }

                    else if (IsMatch(name, PrimaryButtonNames))
                        UITheme.StylePrimaryButton(btn);

                    else if (IsMatch(name, DangerButtonNames))
                        UITheme.StylePrimaryButton(btn,
                            Color.FromArgb(220, 53, 69));
                }
                else if (ctrl is TextBox txt)
                    UITheme.StyleTextBox(txt);

                else if (ctrl is ComboBox cmb)
                    UITheme.StyleComboBox(cmb);

                else if (ctrl is DataGridView dgv)
                    UITheme.StyleGrid(dgv);

                else if (ctrl is Label lbl)
                {
                    if (lbl.Name == "lblMyDocumentsTitle")
                    {
                        lbl.ForeColor = UITheme.TextLight;
                        lbl.Font = UITheme.FontTitle;
                    }
                    else if (lbl.Name == "lblWelcomeHeader")
                    {
                        lbl.ForeColor = UITheme.TextPrimary;
                        lbl.Font = UITheme.FontWelcome;
                    }
                    else
                    {
                        lbl.ForeColor = UITheme.TextPrimary;
                    }
                }

                else if (ctrl is GroupBox grp)
                {
                    grp.ForeColor = UITheme.TextPrimary;
                    grp.Font = UITheme.FontSection;
                    grp.BackColor = UITheme.BgCard;
                }

                else if (ctrl is Panel pnl)
                {
                    string name = pnl.Name;
                    if (name.Contains("Header"))
                        pnl.BackColor = UITheme.BgHeader;
                    else if (name.Contains("Nav") || name.Contains("Navigation"))
                        pnl.BackColor = UITheme.BgNav;
                    else if (!name.Contains("Status") && !name.Contains("Banner"))
                        pnl.BackColor = UITheme.BgPage;
                }

                if (ctrl.HasChildren)
                    ApplyRecursive(ctrl.Controls, activeButtonName);
            }
        }

        private static void StyleHeaderPanel(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Panel pnl && pnl.Name.Contains("Header"))
                {
                    pnl.BackColor = UITheme.BgHeader;

                    foreach (Control child in pnl.Controls)
                    {
                        if (child is Label lbl)
                        {
                            lbl.ForeColor = UITheme.TextLight;
                            lbl.BackColor = Color.Transparent;
                        }
                        if (child is PictureBox pic)
                        {
                            pic.BackColor = Color.Transparent;
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    break;
                }
            }
        }

        private static void StyleNavPanel(Form form, string activeButtonName)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Panel pnl &&
                    (pnl.Name.Contains("Nav") || pnl.Name.Contains("Navigation")))
                {
                    pnl.BackColor = UITheme.BgNav;

                    foreach (Control child in pnl.Controls)
                    {
                        if (child is Button btn)
                        {
                            UITheme.StyleNavButton(
                                btn,
                                btn.Name == activeButtonName
                            );
                        }
                    }
                }
            }
        }

        private static bool IsMatch(string name, string[] list)
        {
            foreach (var n in list)
                if (n == name) return true;
            return false;
        }
    }
}