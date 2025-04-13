using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseAccountRepo
{
    internal class CourseAccountRepo : ICourseAccountRepo
    {
        private readonly E_LearningDB _context;

        public CourseAccountRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(CourseAccount CourseAccount)
        {
            _context.Remove(CourseAccount);
            _context.SaveChanges();
        }

        public IQueryable<CourseAccount> GetAll()
        {
            return _context.CourseAccounts.AsNoTracking();
        }

        public CourseAccount GetById(int id)
        {
            return _context.CourseAccounts.Find(id); //try FindById()
        }

        public void Insert(CourseAccount CourseAccount)
        {
            _context.Add(CourseAccount);
            _context.SaveChanges();
        }

        public void Update(CourseAccount CourseAccount)
        {
            _context.SaveChanges();
        }
    }
}
