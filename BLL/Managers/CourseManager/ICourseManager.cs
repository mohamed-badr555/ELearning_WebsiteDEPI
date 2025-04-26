using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Managers.CourseManager
{
    public interface ICourseManager
    {
        Task<IEnumerable<CourseListDTO>> GetAllAsync();
        Task<PagedResult<CourseListDTO>> GetPagedCoursesAsync(int page, int pageSize);
        Task<CourseDetailsDTO> GetByIdAsync(int id);
        Task<List<CourseListDTO>> SearchCoursesAsync(string SearchItem);
        Task<List<CourseListDTO>> FilterCoursesAsync(string level, string category);
        Task AddAsync(CourseAddDTO Course);
        Task UpdateAsync(CourseAddDTO Course);
        Task DeleteAsync(int id);
    }
}
