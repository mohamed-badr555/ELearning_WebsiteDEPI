using BLL.DTOs;
using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Courses2Controller : ControllerBase
    {
        private readonly E_LearningDB _context;

        public Courses2Controller(E_LearningDB context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCourseWithVideoAndComments(int id)
        {
            var course = await _context.Courses
                .Include(c => c.Video)
                    .ThenInclude(v => v.Comments)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
                return NotFound($"No course found with ID {id}");

            return Ok(course);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCourse([FromBody] Course course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return Ok(course);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCourse(int id, [FromBody] Course updatedCourse)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                return NotFound();

            course.Title = updatedCourse.Title;
            course.Description = updatedCourse.Description;
            await _context.SaveChangesAsync();

            return NoContent();
        }

     
        
    }
}
