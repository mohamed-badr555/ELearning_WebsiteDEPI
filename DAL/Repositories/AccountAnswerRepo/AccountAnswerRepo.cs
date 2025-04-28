using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.AccountAnswerRepo
{
    internal class AccountAnswerRepo : IAccountAnswerRepo
    {
        private readonly E_LearningDB _context;

        public AccountAnswerRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(AccountAnswer accountAnswer)
        {
            _context.Remove(accountAnswer);
            _context.SaveChanges();
        }

        public IQueryable<AccountAnswer> GetAll()
        {
            return _context.AccountAnswers.AsNoTracking();
        }

        public AccountAnswer GetById(int id)
        {
            return _context.AccountAnswers.Find(id);
        }

        public void Insert(AccountAnswer accountAnswer)
        {
            _context.Add(accountAnswer);
            _context.SaveChanges();
        }

        public void Update(AccountAnswer accountAnswer)
        {
            _context.SaveChanges();
        }
    }
}
