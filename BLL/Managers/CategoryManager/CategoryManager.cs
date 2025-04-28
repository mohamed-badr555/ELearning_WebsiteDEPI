using BLL.DTOs.CategoryDTOs;
using DAL.Data.Models;
using DAL.Repositories.CategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CategoryManager
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryManager(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public void Delete(int id)
        {
            var CategoryDto = _categoryRepo.GetById(id);
            _categoryRepo.Delete(CategoryDto);
        }

        public IQueryable<CategoryReadDto> GetAll()
        {
            var CategoryDto = _categoryRepo.GetAll().Select(a => new CategoryReadDto  //*
            {
                //Choose data
            });
            return CategoryDto;
        }

        public CategoryReadDto GetById(int id)
        {
            var CategoryModel = _categoryRepo.GetById(id);

            var CategoryDto = new CategoryReadDto
            {
                //Choose data
            };
            return CategoryDto;
        }

        public void Insert(CategoryAddDto Category)
        {
            var CategoryDto = new Category
            {
                //Add data
            };

            _categoryRepo.Insert(CategoryDto);
        }

        public void Update(CategoryUpdateDto Category)
        {
            var CategoryDto = new Category
            {
                //Update data
            };

            //Another Way?

            //var CategoryModel = _categoryRepo.GetById(Category.id);

            /*
             Data
             */

            _categoryRepo.Update(CategoryDto);
        }
    }
}