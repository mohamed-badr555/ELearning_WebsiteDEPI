using BLL.DTOs.AccountAnswerDTO;
using BLL.DTOs.CategoryDTOs;
using DAL.Data.Models;
using DAL.Repositories.AccountAnswerRepo;
using DAL.Repositories.CategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.AccountAnswerManager
{
    internal class AccountAnswerManager : IAccountAnswerManager
    {
        private readonly IAccountAnswerRepo _accountAnswerRepo;

        public AccountAnswerManager(IAccountAnswerRepo accountAnswerRepo)
        {
            _accountAnswerRepo = accountAnswerRepo;
        }
        public void Delete(int id)
        {
            var AccountAnswerDto = _accountAnswerRepo.GetById(id);
            _accountAnswerRepo.Delete(AccountAnswerDto);
        }

        public IQueryable<AaReadDto> GetAll()
        {
            var AccountAnswerDto = _accountAnswerRepo.GetAll().Select(a => new AaReadDto  //*
            {
                //Choose data
            });
            return AccountAnswerDto;
        }

        public AaReadDto GetById(int id)
        {
            var AccountAnswerModel = _accountAnswerRepo.GetById(id);

            var AccountAnswerDto = new AaReadDto
            {
                //Choose data
            };
            return AccountAnswerDto;
        }

        public void Insert(AaAddDto accountAnser)
        {
            var AccountAnswerDto = new AccountAnswer
            {
                //Add data
            };

            _accountAnswerRepo.Insert(AccountAnswerDto);
        }

        public void Update(AaUpdateDto accountAnser)
        {
            var AccountAnswerDto = new AccountAnswer
            {
                //Update data
            };

            //Another Way?

            //var AccountAnswerModel = _accountAnswerRepo.GetById(AccountAnswer.id);

            /*
             Data
             */

            _accountAnswerRepo.Update(AccountAnswerDto);
        }
    }
}
