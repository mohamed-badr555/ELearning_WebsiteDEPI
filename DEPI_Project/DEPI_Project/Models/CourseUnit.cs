using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class CourseUnit
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(1500)]
        public string? Description { get; set; }   
        public int Order { get; set; }

        #region CourseUnit - Course (M-1)
        public int CourseID { get; set; } //Foreign key
        public Course Courses { get; set; }
        #endregion

        #region Course - Video (1-M)
        public ICollection<Video> videos { get; set; } 
        #endregion
    }
}
