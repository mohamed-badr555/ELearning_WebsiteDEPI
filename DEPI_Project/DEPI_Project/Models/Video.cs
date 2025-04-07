using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class Video
    {
        public int ID { get; set; }
        [MaxLength(75)]
        public string Title { get; set; }
        [MaxLength(1500)]
        public string? Description { get; set; }
        [MaxLength(1500)]
        public string URL { get; set; }
        public int order { get; set; }

        #region Video - CourseUnitID (M-1)
        public int CourseUnitID { get; set; } //Foreign key
        public CourseUnit CourseUnits { get; set; }
        #endregion

        #region Video  - VideoComments (M-M)
        public ICollection<VideoComment> VideoComments { get; set; }
        #endregion

        #region Video - Exam (1-1)
        public int ExamID { get; set; }
        public Exam Exam { get; set; } 
        #endregion
    }
}
