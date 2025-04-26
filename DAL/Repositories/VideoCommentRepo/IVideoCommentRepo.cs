using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.VideoCommentRepo
{
    public interface IVideoCommentRepo
    {
        IQueryable<VideoComment> GetAll();
        VideoComment GetById(int id);
        void Insert(VideoComment VideoComment);
        void Update(VideoComment VideoComment);
        void Delete(VideoComment VideoComment);
    }
}
