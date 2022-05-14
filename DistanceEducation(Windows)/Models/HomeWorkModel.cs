using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.Models
{
    internal class HomeWorkModel
    {
        public string Date { get; set; }
        public string Exercise { get; set; }
        public string Subject { get; set; }
        public bool Status { get; set; }

        public HomeWorkModel(string date, string exercise, string subject, bool status)
        {
            Date = date;
            Exercise = exercise;
            Subject = subject;
            Status = status;
        }
    }
}
