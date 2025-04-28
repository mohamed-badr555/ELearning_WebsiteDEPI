using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static DAL.Repositories.CourseRepo.CourseRepo;

namespace DAL.Repositories.CourseRepo
{
    public class CourseRepo : GenericRepository<Course>, ICourseRepo
    {


        public CourseRepo(E_LearningDB context) : base(context) { }

        public Task AddAsync(Course course)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Course>> ICourseRepo.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public class CourseRepository : ICourseRepo
        {
            private readonly E_LearningDB _context;

            public CourseRepository(E_LearningDB context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Course>> GetAllAsync()
            {
                return await _context.Courses.Include(c => c.Videos).ThenInclude(v => v.Comments).ToListAsync();
            }
            public async Task AddAsync(Course course)
            {
                await _context.Courses.AddAsync(course);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Course course)
            {
                _context.Courses.Update(course);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(Course course)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }

            public Task<Course> GetByIdAsync(int id)
            {
                throw new NotImplementedException();
            }

            Task<List<Course>> IGenericRepository<Course>.GetAllAsync()
            {
                throw new NotImplementedException();
            }

            public Task InsertAsync(Course entity)
            {
                throw new NotImplementedException();
            }

            public Task<bool> AnyAsync(Expression<Func<Course, bool>> predicate)
            {
                throw new NotImplementedException();
            }

            //public async Task<List<Course>> SearchAsync(string query)
            //{
            //    return await _dbContext.Courses
            //        .Where(c => c.Title.ToLower().Contains(query.ToLower()) ||
            //                    c.Description.ToLower().Contains(query.ToLower()))
            //        .ToListAsync();
            //}
        }
    }

   
}