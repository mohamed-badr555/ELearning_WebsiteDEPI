using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseAccountRepo
{
    public interface ICourseAccountRepo
    {
        IQueryable<CourseAccount> GetAll();
        CourseAccount GetById(int id);
        void Insert(CourseAccount CourseAccount);
        void Update(CourseAccount CourseAccount);
        void Delete(CourseAccount CourseAccount);
    }
}
