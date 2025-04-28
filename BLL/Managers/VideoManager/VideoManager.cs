using DAL.Data.Models;
using DAL.Repositories.CourseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Repositories.CourseRepo.CourseRepo;
using static DAL.Repositories.VideoRepo.IVideoRepo;

namespace BLL.Managers.video
{

    public class VideoManager
    {
        private readonly IVideoRepository _videoRepository;
        private readonly ICourseRepo _courseRepository;

        public VideoManager(IVideoRepository videoRepository, ICourseRepo courseRepository)
        {
            _videoRepository = videoRepository;
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Video>> GetAllVideosAsync()
        {
            return await _videoRepository.GetAllAsync();
        }

        public async Task<Video> GetVideoByIdAsync(int id)
        {
            return await _videoRepository.GetByIdAsync(id);
        }

        public async Task AddVideoAsync(Video video)
        {
            var course = await _courseRepository.GetByIdAsync(video.CourseId);
            if (course == null)
            {
                throw new Exception("Cannot add video. Course not found.");
            }

            await _videoRepository.AddAsync(video);
        }

        public async Task UpdateVideoAsync(Video video)
        {
            await _videoRepository.UpdateAsync(video);
        }

        public async Task DeleteVideoAsync(Video video)
        {
            await _videoRepository.DeleteAsync(video);
        }

    }
}




