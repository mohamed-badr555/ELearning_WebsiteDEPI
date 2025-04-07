using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class Question
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        [MaxLength(50)]
        public string Text { get; set; }//Note
        public float Mark { get; set; }

        #region Question - Exam (M-1)
        public int ExamID { get; set; }//Forign key
        public Exam Exam { get; set; } 
        #endregion

        #region Question - QuestionChoices (1-M)
        //1-M
        public ICollection<QuestionChoice> QuestionChoices { get; set; }
        #endregion

        #region Question - QuestionChoices (1-1)
        //1-1
        public int? QuestionChoiceID { get; set; }
        public QuestionChoice QuestionChoice { get; set; } 
        #endregion
    }
}
