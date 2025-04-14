using BLL.DTOs.CourseUnitDTOs;
using BLL.DTOs.ExamDTOs;
using DAL.Data.Models;
using DAL.Repositories.CourseUnitRepo;
using DAL.Repositories.ExamRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.ExamManager
{
    public class ExamManager : IExamManager
    {
        private readonly IExamRepo _examRepo;

        public ExamManager(IExamRepo examRepo)
        {
            _examRepo = examRepo;
        }
        public void Delete(int id)
        {
            var ExamDto = _examRepo.GetById(id);
            _examRepo.Delete(ExamDto);
        }

        public IEnumerable<ExamReadDto> GetAll()
        {
            var ExamDto = _examRepo.GetAll().Select(a => new ExamReadDto  //*
            {
                //Choose data
            });
            return ExamDto;
        }

        public ExamReadDto GetById(int id)
        {
            var ExamModel = _examRepo.GetById(id);

            var ExamDto = new ExamReadDto
            {
                //Choose data
            };
            return ExamDto;
        }

        public void Insert(ExamAddDto exam)
        {
            var ExamDto = new Exam
            {
                //Add data
            };

            _examRepo.Insert(ExamDto);
        }

        public void Update(ExamUpdateDto exam)
        {
            var ExamDto = new Exam
            {
                //Update data
            };

            //Another Way?

            //var ExamModel = _examRepo.GetById(Exam.id);

            /*
             Data
             */

            _examRepo.Update(ExamDto);
        }
    }
}
