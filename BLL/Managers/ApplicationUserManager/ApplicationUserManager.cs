using BLL.DTOs.ApplicationUserDTOs;
using BLL.DTOs.CategoryDTOs;
using DAL.Data.Models;
using DAL.Repositories.ApplicationUserRepo;
using DAL.Repositories.CategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.ApplicationUserManager
{
    internal class ApplicationUserManager : IApplicationUserManager
    {
        private readonly IApplicationUserRepo _applicationUserRepo;

        public ApplicationUserManager(IApplicationUserRepo applicationUserRepo)
        {
            _applicationUserRepo = applicationUserRepo;
        }
        public void Delete(int id)
        {
            var ApplicationUserDto = _applicationUserRepo.GetById(id);
            _applicationUserRepo.Delete(ApplicationUserDto);
        }

        public IEnumerable<AuReadDto> GetAll()
        {
            var ApplicationUserDto = _applicationUserRepo.GetAll().Select(a => new AuReadDto  //*
            {
                //Choose data
            });
            return ApplicationUserDto;
        }

        public AuReadDto GetById(int id)
        {
            var ApplicationUserModel = _applicationUserRepo.GetById(id);

            var ApplicationUserDto = new AuReadDto
            {
                //Choose data
            };
            return ApplicationUserDto;
        }

        public void Insert(AuAddDto applicationUser)
        {
            var ApplicationUserDto = new ApplicationUser
            {
                //Add data
            };

            _applicationUserRepo.Insert(ApplicationUserDto);
        }

        public void Update(AuUpdateDto applicationUser)
        {
            var ApplicationUserDto = new ApplicationUser
            {
                //Update data
            };

            //Another Way?

            //var ApplicationUserModel = _applicationUserRepo.GetById(ApplicationUser.id);

            /*
             Data
             */

            _applicationUserRepo.Update(ApplicationUserDto);
        }
    }
}