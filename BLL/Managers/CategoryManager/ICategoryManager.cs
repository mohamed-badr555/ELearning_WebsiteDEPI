using BLL.DTOs.CategoryDTOs;
using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CategoryManager
{
    public interface ICategoryManager
    {
        IEnumerable<CategoryReadDto> GetAll();
        CategoryReadDto GetById(int id);
        void Insert(CategoryAddDto Category);
        void Update(CategoryUpdateDto Category);
        void Delete(int id);
    }
}
