using BLL.DTOs.CourseAccountDTOs;
using BLL.DTOs.CourseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseAccount
{
    public interface ICourseAccountManager
    {
        IQueryable<CaReadDto> GetAll();
        CaReadDto GetById(int id);
        void Insert(CaAddDto CourseAccount);
        void Update(CaUpdateDto CourseAccount);
        void Delete(int id);
    }
}
