using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseUnitRepo
{
    public interface ICourseUnitRepo
    {
        IQueryable<CourseUnit> GetAll();
        CourseUnit GetById(int id);
        void Insert(CourseUnit CourseUnit);
        void Update(CourseUnit CourseUnit);
        void Delete(CourseUnit CourseUnit);
    }
}
