using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Project
{
    class Job
    {
        public int JobId { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string EmploymentType { get; set; }
        public string Status { get; set; }

        public string Qualifications { get; set; }
        public string Requirements { get; set; }
    }
}
