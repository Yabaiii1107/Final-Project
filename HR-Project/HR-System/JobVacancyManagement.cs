using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobVacancyManagement
{
    public partial class JobVacancyManagement : Form
    {
        public JobVacancyManagement()
        {
            InitializeComponent();
        }

        private void txtQualInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtJobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
                System.Media.SystemSounds.Beep.Play(); 
            }
        }

        private void lblWelcomeHR_Click(object sender, EventArgs e)
        {

        }
    }
}
