using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseUnitDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseUnitManager
{
    public interface ICourseUnitManager
    {
        IEnumerable<CourseUnitReadDto> GetAll();
        CourseUnitReadDto GetById(int id);
        void Insert(CourseUnitAddDto courseUnit);
        void Update(CourseUnitUpdateDto courseUnit);
        void Delete(int id);
    }
}
