using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseDTOs;
using DAL.Data.Models;
using DAL.Repositories.CategoryRepo;
using DAL.Repositories.CourseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseManager
{
    internal class CourseMananger : ICourseMananger
    {
        private readonly ICourseRepo _courseRepo;

        public CourseMananger(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        public void Delete(int id)
        {
            var CourseDto = _courseRepo.GetById(id);
            _courseRepo.Delete(CourseDto);
        }

        public IEnumerable<CourseReadDto> GetAll()
        {
            var CourseDto = _courseRepo.GetAll().Select(a => new CourseReadDto  //*
            {
                //Choose data
            });
            return CourseDto;
        }

        public CourseReadDto GetById(int id)
        {
            var CourseModel = _courseRepo.GetById(id);

            var CourseDto = new CourseReadDto
            {
                //Choose data
            };
            return CourseDto;
        }

        public void Insert(CourseAddDto Course)
        {
            var CourseDto = new Course
            {
                //Add data
            };

            _courseRepo.Insert(CourseDto);
        }

        public void Update(CourseUpdateDto Course)
        {
            var CourseDto = new Course
            {
                //Update data
            };

            //Another Way?

            //var CourseModel = _courseRepo.GetById(Course.id);

            /*
             Data
             */

            _courseRepo.Update(CourseDto);
        }
    }
}
