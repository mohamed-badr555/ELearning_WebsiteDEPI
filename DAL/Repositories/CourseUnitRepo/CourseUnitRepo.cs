using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseUnitRepo
{
    public class CourseUnitRepo : ICourseUnitRepo
    {
        private readonly E_LearningDB _context;

        public CourseUnitRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(CourseUnit CourseUnit)
        {
            _context.Remove(CourseUnit);
            _context.SaveChanges();
        }

        public IQueryable<CourseUnit> GetAll()
        {
            return _context.CourseUnits.AsNoTracking();
        }

        public CourseUnit GetById(int id)
        {
            return _context.CourseUnits.Find(id);
        }

        public void Insert(CourseUnit CourseUnit)
        {
            _context.Add(CourseUnit);
            _context.SaveChanges();
        }

        public void Update(CourseUnit CourseUnit)
        {
            _context.SaveChanges();
        }
    }
}
