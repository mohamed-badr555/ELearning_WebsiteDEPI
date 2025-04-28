using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ApplicationUserRepo
{
    public interface IApplicationUserRepo
    {
        IQueryable<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
        void Insert(ApplicationUser ApplicationUser);
        void Update(ApplicationUser ApplicationUser);
        void Delete(ApplicationUser ApplicationUser);
    }
}
