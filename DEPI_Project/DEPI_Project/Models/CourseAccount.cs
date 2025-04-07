using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class CourseAccount
    {
        //NOOOOOOOOOTES 
        public int CourseID { get; set; } //foreign key
        public Course courses { get; set; }

        public int AccountID { get; set; }//foreign key
        public Account Accounts { get; set; }

        public int FinishedUnits { get; set; }
        public bool IsCompleted { get; set; }
        public float CompTime { get; set; }
        public float SubsTime { get; set; }
        public float Progress { get; set; }
        public int LastVideo { get; set; }
        public int RateText { get; set; }
        public int RateStars { get; set; }
    }
}
