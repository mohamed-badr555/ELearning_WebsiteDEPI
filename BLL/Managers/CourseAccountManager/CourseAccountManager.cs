using BLL.DTOs.CourseAccountDTOs;
using BLL.DTOs.CourseDTOs;
using DAL.Data.Models;
using DAL.Repositories.CourseAccountRepo;
using DAL.Repositories.CourseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseAccount
{
    internal class CourseAccountManager : ICourseAccountManager
    {
        private readonly ICourseAccountRepo _courseAccountRepo;

        public CourseAccountManager(ICourseAccountRepo courseAccountRepo)
        {
            _courseAccountRepo = courseAccountRepo;
        }
        public void Delete(int id)
        {
            var CaDto = _courseAccountRepo.GetById(id);
            _courseAccountRepo.Delete(CaDto);
        }

        public IQueryable<CaReadDto> GetAll()
        {
            var CaDto = _courseAccountRepo.GetAll().Select(a => new CaReadDto  //*
            {
                //Choose data
            });
            return CaDto;
        }

        public CaReadDto GetById(int id)
        {
            var CaModel = _courseAccountRepo.GetById(id);

            var CaDto = new CaReadDto
            {
                //Choose data
            };
            return CaDto;
        }

        public void Insert(CaAddDto CourseAccount)
        {
            //notes

            //var CaDto = new CourseAccount
            //{
            //    //Add data
            //};

            //_courseAccountRepo.Insert(CaDto);
        }

        public void Update(CaUpdateDto CourseAccount)
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

            //_courseRepo.Update(CourseDto);
        }
    }
}
