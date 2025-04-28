using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class Video :BaseEntity
    {
       
        [MaxLength(75)]
        public string? Title { get; set; }
        [MaxLength(1500)]
        public string? Description { get; set; }
        [MaxLength(1500)]
        public string? URL { get; set; }
        public int order { get; set; }
        public  int? Id { get; set; }
        public string? FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public int UploadedByUserId { get; set; }
        public required ICollection<Comment> Comments { get; set; }
        public int CourseId { get; set; }    // 🔥 FK
        public Course? Course { get; set; }   // 🔥 Navigation Property


        #region Video - CourseUnitID (M-1)
        public int CourseUnitID { get; set; } //Foreign key
        public CourseUnit CourseUnit { get; set; }
        #endregion

        #region Video - Exam (1-1)
        public int? ExamID { get; set; }
        public Exam Exam { get; set; }
        public object Comment { get; internal set; }
        #endregion
    }
}
