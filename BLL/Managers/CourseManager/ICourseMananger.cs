using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseManager
{
    public interface ICourseMananger
    {
        IEnumerable<CourseReadDto> GetAll();
        CourseReadDto GetById(int id);
        void Insert(CourseAddDto Course);
        void Update(CourseUpdateDto Course);
        void Delete(int id);
    }
}
