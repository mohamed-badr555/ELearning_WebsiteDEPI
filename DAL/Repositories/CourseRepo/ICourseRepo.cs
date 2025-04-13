using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseRepo
{
    public interface ICourseRepo
    {
        IQueryable<Course> GetAll();
        Course GetById(int id);
        void Insert(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
