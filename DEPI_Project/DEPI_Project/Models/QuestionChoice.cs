using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class QuestionChoice
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Text { get; set; }

        #region QuestionChoices - Question (M-1)
        //M-1
        public int? QuestionID { get; set; } //Foreign key // NOOOOOOOoooooooooooooTe
        //public int QID { get; set; }
        //[ForeignKey("QID")]
        public Question Question { get; set; }
        #endregion

        #region QuestionChoices - Question (1-1)
        //1-1
        public Question Question2 { get; set; } 
        #endregion
    }
}
