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
    public class CourseRepo : GenericRepository<Course> , ICourseRepo
    {
      

        public CourseRepo(E_LearningDB context) : base(context) { }


        //public async Task<List<Course>> SearchAsync(string query)
        //{
        //    return await _dbContext.Courses
        //        .Where(c => c.Title.ToLower().Contains(query.ToLower()) ||
        //                    c.Description.ToLower().Contains(query.ToLower()))
        //        .ToListAsync();
        //}
    }
}
