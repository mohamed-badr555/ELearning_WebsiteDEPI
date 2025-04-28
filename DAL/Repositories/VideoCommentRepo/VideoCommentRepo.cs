using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.VideoCommentRepo
{
    internal class VideoCommentRepo : IVideoCommentRepo
    {
        private readonly E_LearningDB _context;

        public VideoCommentRepo(E_LearningDB context)
        {
            _context = context;
        }
        public void Delete(VideoComment VideoComment)
        {
            _context.Remove(VideoComment);
            _context.SaveChanges();
        }

        public IQueryable<VideoComment> GetAll()
        {
            return _context.VideoComments.AsNoTracking();
        }

        public VideoComment GetById(int id)
        {
            return _context.VideoComments.Find(id);
        }

        public void Insert(VideoComment VideoComment)
        {
            _context.Add(VideoComment);
            _context.SaveChanges();
        }

        public void Update(VideoComment VideoComment)
        {
            _context.SaveChanges();
        }
    }
}
