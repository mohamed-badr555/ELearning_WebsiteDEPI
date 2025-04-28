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
        Task AddVideoAsync(Video video);
        Task DeleteVideoAsync(Video video);
        Task<IEnumerable<Video>> GetAllVideosAsync();
        Task<Video> GetVideoByIdAsync(int id);
        Task UpdateVideoAsync(Video video);

        public interface IVideoRepository
        {
            Task<IEnumerable<Video>> GetAllVideosAsync();
            Task<Video> GetVideoByIdAsync(int videoId);
            Task AddVideoAsync(Video video);
            Task UpdateVideoAsync(Video video);
            Task DeleteVideoAsync(Video video);
            Task<IEnumerable<Video>> GetVideosByCourseIdAsync(int courseId); // Connect with courses
            Task<IEnumerable<Video>> GetAllAsync();
            Task<Video> GetByIdAsync(int id);
            Task AddAsync(Video video);
            Task UpdateAsync(Video video);
            Task DeleteAsync(Video video);
        }
    }
}
