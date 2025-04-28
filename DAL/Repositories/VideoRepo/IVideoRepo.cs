using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.VideoRepo
{
    public interface IVideoRepo
    {
        IQueryable<Video> GetAll();
        Video GetById(int id);
        void Insert(Video Video);
        void Update(Video Video);
        void Delete(Video Video);
    }
}
