using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.QuestionChoiceRepo
{
    public class QuestionChoiceRepo : IQuestionChoiceRepo
    {
        private readonly E_LearningDB _context;

        public QuestionChoiceRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(QuestionChoice QuestionChoice)
        {
            _context.Remove(QuestionChoice);
            _context.SaveChanges();
        }

        public IQueryable<QuestionChoice> GetAll()
        {
            return _context.QuestionChoices.AsNoTracking();
        }

        public QuestionChoice GetById(int id)
        {
            return _context.QuestionChoices.Find(id);
        }

        public void Insert(QuestionChoice QuestionChoice)
        {
            _context.Add(QuestionChoice);
            _context.SaveChanges();
        }

        public void Update(QuestionChoice QuestionChoice)
        {
            _context.SaveChanges();
        }
    }
}
