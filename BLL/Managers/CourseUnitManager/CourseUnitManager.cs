using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseUnitDTOs;
using BLL.Managers.CourseAccountManager;
using DAL.Data.Models;
using DAL.Repositories.CategoryRepo;
using DAL.Repositories.CourseUnitRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseUnitManager
{
    internal class CourseUnitManager : ICourseUnitManager
    {
        private readonly ICourseUnitRepo _courseUnitRepo;

        public CourseUnitManager(ICourseUnitRepo courseUnitRepo)
        {
            _courseUnitRepo = courseUnitRepo;
        }
        public void Delete(int id)
        {
            var CourseUnitDto = _courseUnitRepo.GetById(id);
            _courseUnitRepo.Delete(CourseUnitDto);
        }

        public IEnumerable<CourseUnitReadDto> GetAll()
        {
            var CourseUnitDto = _courseUnitRepo.GetAll().Select(a => new CourseUnitReadDto  //*
            {
                //Choose data
            });
            return CourseUnitDto;
        }

        public CourseUnitReadDto GetById(int id)
        {
            var CourseUnitModel = _courseUnitRepo.GetById(id);

            var CourseUnitDto = new CourseUnitReadDto
            {
                //Choose data
            };
            return CourseUnitDto;
        }

        public void Insert(CourseUnitAddDto courseUnit)
        {
            var CourseUnitDto = new CourseUnit
            {
                //Add data
            };

            _courseUnitRepo.Insert(CourseUnitDto);
        }

        public void Update(CourseUnitUpdateDto courseUnit)
        {
            var CourseUnitDto = new CourseUnit
            {
                //Update data
            };

            //Another Way?

            //var CategoryModel = _categoryRepo.GetById(Category.id);

            /*
             Data
             */

            _courseUnitRepo.Update(CourseUnitDto);
        }
    }
}
