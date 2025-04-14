using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseRepo
{
    public class CourseRepo : ICourseRepo
    {
        private readonly E_LearningDB _context;

        public CourseRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(Course course)
        {
            _context.Remove(course);
            _context.SaveChanges();
        }

        public IQueryable<Course> GetAll()
        {
            return _context.Courses.AsNoTracking();
        }

        public Course GetById(int id)
        {
            return _context.Courses.Find(id);
        }

        public void Insert(Course course)
        {
            _context.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            _context.SaveChanges();
        }
    }
}
