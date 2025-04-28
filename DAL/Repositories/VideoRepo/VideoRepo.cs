using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;


namespace DAL.Repositories.VideoRepo
{
    public class VideoService
    {
        private readonly IVideoRepo _videoRepository;

        public VideoService(IVideoRepo videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public async Task<IEnumerable<Video>> GetAllVideosAsync()
        {
            return await _videoRepository.GetAllVideosAsync();
        }

        public async Task<Video> GetVideoByIdAsync(int id)
        {
            return await _videoRepository.GetVideoByIdAsync(id);
        }

        public async Task AddVideoAsync(Video video)
        {
            await _videoRepository.AddVideoAsync(video);
        }

        public async Task UpdateVideoAsync(Video video)
        {
            await _videoRepository.UpdateVideoAsync(video);
        }

        public async Task DeleteVideoAsync(Video video)
        {
            await _videoRepository.DeleteVideoAsync(video);
        }
    }
}
