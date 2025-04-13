using BLL.DTOs.AccountAnswerDTO;
using BLL.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.AccountAnswerManager
{
    public interface IAccountAnswerManager
    {
        IQueryable<AaReadDto> GetAll();
        AaReadDto GetById(int id);
        void Insert(AaAddDto accountAnswer);
        void Update(AaUpdateDto accountAnswer);
        void Delete(int id);
    }
}
