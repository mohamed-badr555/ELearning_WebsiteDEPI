using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CategoryRepo
{
    internal class CategoryRepo : ICategoryRepo
    {
        private readonly E_LearningDB _context;

        public CategoryRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories.AsNoTracking();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Insert(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.SaveChanges();
        }
    }
}
