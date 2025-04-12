using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ApplicationUserRepo
{
    internal class ApplicationUserRepo : IApplicationUserRepo
    {
        private readonly E_LearningDB _context;

        public ApplicationUserRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(ApplicationUser ApplicationUser)
        {
            _context.Remove(ApplicationUser);
            _context.SaveChanges();
        }

        public IQueryable<ApplicationUser> GetAll()
        {
            return _context.ApplicationUsers.AsNoTracking();
        }

        public ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.Find(id);
        }

        public void Insert(ApplicationUser ApplicationUser)
        {
            _context.Add(ApplicationUser);
            _context.SaveChanges();
        }

        public void Update(ApplicationUser ApplicationUser)
        {
            _context.SaveChanges();
        }
    }
}
