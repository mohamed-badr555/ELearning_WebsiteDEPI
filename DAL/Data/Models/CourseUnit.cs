using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
<<<<<<< HEAD
    public class CourseUnit 
=======
    public class CourseUnit
>>>>>>> origin/register
    {
       
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }
        public int Order { get; set; }

        #region CourseUnit - Course (M-1)
        public int CourseID { get; set; } //Foreign key
        public Course Course { get; set; }
        #endregion

        #region Course - Video (1-M)
        public ICollection<Video> videos { get; set; }
        #endregion
    }
}
