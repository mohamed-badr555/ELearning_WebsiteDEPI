using BLL.DTOs.CourseUnitDTOs;
using BLL.DTOs.ExamDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.ExamManager
{
    public interface IExamManager
    {
        IQueryable<ExamReadDto> GetAll();
        ExamReadDto GetById(int id);
        void Insert(ExamAddDto exam);
        void Update(ExamUpdateDto exam);
        void Delete(int id);
    }
}
