using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.QuestionRepo
{
    internal class QuestionRepo : IQuestionRepo
    {
        private readonly E_LearningDB _context;

        public QuestionRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(Question Question)
        {
            _context.Remove(Question);
            _context.SaveChanges();
        }

        public IQueryable<Question> GetAll()
        {
            return _context.Questions.AsNoTracking();
        }

        public Question GetById(int id)
        {
            return _context.Questions.Find(id);
        }

        public void Insert(Question Question)
        {
            _context.Add(Question);
            _context.SaveChanges();
        }

        public void Update(Question Question)
        {
            _context.SaveChanges();
        }
    }
}
