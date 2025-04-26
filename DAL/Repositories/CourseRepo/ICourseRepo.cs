using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseRepo
{
    public interface ICourseRepo : IGenericRepository<Course>
    {
        //Task<List<Course>> SearchAsync(string query);
    }
}
