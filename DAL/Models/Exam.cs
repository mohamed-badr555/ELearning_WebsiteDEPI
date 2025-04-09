using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Exam
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public float SuccessGrade { get; set; }
        public float FullMark { get; set; }
        [MaxLength(30)]
        public TimeSpan TimeInMinutes { get; set; }


        #region Exam - Video (1-1)
        public Video Video { get; set; }
        #endregion

        #region Exam - Question (1-M)
        public ICollection<Question> Questions { get; set; }
        #endregion

        #region Exam - AccountAnswer (1-M)
        public ICollection<AccountAnswer> AccountAnswers { get; set; }
        #endregion
    }
}
