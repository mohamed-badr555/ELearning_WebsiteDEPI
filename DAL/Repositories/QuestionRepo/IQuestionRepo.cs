using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.QuestionRepo
{
    public interface IQuestionRepo
    {
        IQueryable<Question> GetAll();
        Question GetById(int id);
        void Insert(Question Question);
        void Update(Question Question);
        void Delete(Question Question);
    }
}
