using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Project.HR_System
{
    public partial class HRDashboard : Form
    {
        public string UserRole { get; set; }

        public string UserName { get; set; }

        public HRDashboard()
        {
            InitializeComponent();
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {

        }
    }
}
