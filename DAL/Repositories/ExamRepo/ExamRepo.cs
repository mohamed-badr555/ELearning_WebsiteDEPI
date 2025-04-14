using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ExamRepo
{
    public class ExamRepo : IExamRepo
    {
        private readonly E_LearningDB _context;

        public ExamRepo(E_LearningDB context)
        {
            _context = context;
        }

        public void Delete(Exam Exam)
        {
            _context.Remove(Exam);
            _context.SaveChanges();
        }

        public IQueryable<Exam> GetAll()
        {
            return _context.Exams.AsNoTracking();
        }

        public Exam GetById(int id)
        {
            return _context.Exams.Find(id);
        }

        public void Insert(Exam Exam)
        {
            _context.Add(Exam);
            _context.SaveChanges();
        }

        public void Update(Exam Exam)
        {
            _context.SaveChanges();
        }
    }
}
