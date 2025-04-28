using BLL.DTOs.QuestionChoiceDTOs;
using BLL.DTOs.QuestionDTOs;
using DAL.Data.Models;
using DAL.Repositories.QuestionChoiceRepo;
using DAL.Repositories.QuestionRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.QuestionChoiceManager
{
    internal class QuestionChoiceManager : IQuestionChoiceManager
    {
        private readonly IQuestionChoiceRepo _questionChoiceRepo;

        public QuestionChoiceManager(IQuestionChoiceRepo questionChoiceRepo)
        {
            _questionChoiceRepo = questionChoiceRepo;
        }
        public void Delete(int id)
        {
            var QuestionChoiceDto = _questionChoiceRepo.GetById(id);
            _questionChoiceRepo.Delete(QuestionChoiceDto);
        }

        public IQueryable<QcReadDto> GetAll()
        {
            var QuestionChoiceDto = _questionChoiceRepo.GetAll().Select(a => new QcReadDto  //*
            {
                //Choose data
            });
            return QuestionChoiceDto;
        }

        public QcReadDto GetById(int id)
        {
            var QuestionChoiceModel = _questionChoiceRepo.GetById(id);

            var QuestionChoiceDto = new QcReadDto
            {
                //Choose data
            };
            return QuestionChoiceDto;
        }

        public void Insert(QcAddDto exam)
        {
            var QuestionChoiceDto = new QuestionChoice
            {
                //Add data
            };

            _questionChoiceRepo.Insert(QuestionChoiceDto);
        }

        public void Update(QcUpdateDto exam)
        {
            var QuestionChoiceDto = new QuestionChoice
            {
                //Update data
            };

            //Another Way?

            //var QuestionChoiceModel = _questionChoiceRepo.GetById(QuestionChoice.id);

            /*
             Data
             */

            _questionChoiceRepo.Update(QuestionChoiceDto);
        }
    }
}