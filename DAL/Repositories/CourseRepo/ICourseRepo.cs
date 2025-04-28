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
        //Task<Liublic interface ICourseRepository
    
        
    
     new Task<IEnumerable<Course>> GetAllAsync();
        new Task<Course> GetByIdAsync(int id);
        Task AddAsync(Course course);
        new Task UpdateAsync(Course course);
        new Task DeleteAsync(Course course);
    }
  

    
}
