using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.VideoRepo
{
    internal class VideoRepo : IVideoRepo
    {
        private readonly E_LearningDB _context;

        public VideoRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(Video Video)
        {
            _context.Remove(Video);
            _context.SaveChanges();
        }

        public IQueryable<Video> GetAll()
        {
            return _context.Videos.AsNoTracking();
        }

        public Video GetById(int id)
        {
            return _context.Videos.Find(id);
        }

        public void Insert(Video Video)
        {
            _context.Add(Video);
            _context.SaveChanges();
        }

        public void Update(Video Video)
        {
            _context.SaveChanges();
        }
    }
}
