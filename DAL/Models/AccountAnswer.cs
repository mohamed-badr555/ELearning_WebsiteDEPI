using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AccountAnswer
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int AccountId { get; set; }
        public ApplicationUser User { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        [MaxLength(100)]
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
 

    }
}
