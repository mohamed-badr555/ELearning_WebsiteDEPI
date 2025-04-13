using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseAccountDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseAccountManager
{
    public interface ICourseAccountManager
    {
        IQueryable<CaReadDto> GetAll();
        CaReadDto GetById(int id);
        void Insert(CaAddDto courseAccount);
        void Update(CaUpdateDto courseAccount);
        void Delete(int id);
    }
}
