using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.AccountAnswerRepo
{
    public interface IAccountAnswerRepo
    {
        IQueryable<AccountAnswer> GetAll();
        AccountAnswer GetById(int id);
        void Insert(AccountAnswer accountAnswer);
        void Update(AccountAnswer accountAnswer);
        void Delete(AccountAnswer accountAnswer);
    }
}
