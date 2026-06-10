using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERVIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the active event handler wired to your Form's Load behavior.
        /// Now populated with an expanded list of interview queue tracking items.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Original Records
            dgvInterviews.Rows.Add(
                1,
                "06/15/2026",
                "09:00 AM",
                "Engr. Juan Dela Cruz",
                "Online",
                "Scheduled");

            dgvInterviews.Rows.Add(
                2,
                "06/12/2026",
                "02:30 PM",
                "Prof. Smith Garcia",
                "Onsite",
                "Completed");

            dgvInterviews.Rows.Add(
                3,
                "06/10/2026",
                "10:15 AM",
                "Ms. Angela Reyes",
                "Online",
                "Cancelled");

            // New Additional Records
            dgvInterviews.Rows.Add(
                4,
                "06/16/2026",
                "11:00 AM",
                "Ms. Samantha Vera",
                "Onsite",
                "Scheduled");

            dgvInterviews.Rows.Add(
                5,
                "06/16/2026",
                "01:45 PM",
                "Arch. Kierra Zylene",
                "Online",
                "Pending");

            dgvInterviews.Rows.Add(
                6,
                "06/17/2026",
                "08:30 AM",
                "Mr. Clyden Ramirez",
                "Online",
                "Scheduled");

            dgvInterviews.Rows.Add(
                7,
                "06/17/2026",
                "03:00 PM",
                "Atty. Tyron Dela Cruz",
                "Onsite",
                "Completed");

            dgvInterviews.Rows.Add(
                8,
                "06/18/2026",
                "10:00 AM",
                "Ms. Chloe Aguilar",
                "Online",
                "Pending");

            dgvInterviews.Rows.Add(
                9,
                "06/19/2026",
                "04:15 PM",
                "Engr. Avianna Diaz",
                "Onsite",
                "Scheduled");
             
        }
    }
}