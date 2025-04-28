using BLL.DTOs.ExamDTOs;
using BLL.DTOs.QuestionDTOs;
using DAL.Data.Models;
using DAL.Repositories.ExamRepo;
using DAL.Repositories.QuestionRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.QuestionManager
{
    internal class QuestionManager : IQuestionManager
    {
        private readonly IQuestionRepo _questionRepo;

        public QuestionManager(IQuestionRepo questionRepo)
        {
            _questionRepo = questionRepo;
        }
        public void Delete(int id)
        {
            var QuestionDto = _questionRepo.GetById(id);
            _questionRepo.Delete(QuestionDto);
        }

        public IQueryable<QuestionReadDto> GetAll()
        {
            var QuestionDto = _questionRepo.GetAll().Select(a => new QuestionReadDto  //*
            {
                //Choose data
            });
            return QuestionDto;
        }

        public QuestionReadDto GetById(int id)
        {
            var QuestionModel = _questionRepo.GetById(id);

            var QuestionDto = new QuestionReadDto
            {
                //Choose data
            };
            return QuestionDto;
        }

        public void Insert(QuestionAddDto exam)
        {
            var QuestionDto = new Question
            {
                //Add data
            };

            _questionRepo.Insert(QuestionDto);
        }

        public void Update(QuestionUpdateDto exam)
        {
            var QuestionDto = new Question
            {
                //Update data
            };

            //Another Way?

            //var QuestionModel = _questionRepo.GetById(Question.id);

            /*
             Data
             */

            _questionRepo.Update(QuestionDto);
        }
    }
}
