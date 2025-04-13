using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.QuestionChoiceRepo
{
    public interface IQuestionChoiceRepo
    {
        IQueryable<QuestionChoice> GetAll();
        QuestionChoice GetById(int id);
        void Insert(QuestionChoice QuestionChoice);
        void Update(QuestionChoice QuestionChoice);
        void Delete(QuestionChoice QuestionChoice);
    }
}
