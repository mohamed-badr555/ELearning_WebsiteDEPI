using BLL.DTOs.ApplicationUserDTOs;
using BLL.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.ApplicationUserManager
{
    public interface IApplicationUserManager
    {
        IQueryable<AuReadDto> GetAll();
        AuReadDto GetById(int id);
        void Insert(AuAddDto applicationUser);
        void Update(AuUpdateDto applicationUser);
        void Delete(int id);
    }
}
