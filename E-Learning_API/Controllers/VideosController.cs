using DAL.Data.Models;
using DAL.Repositories.VideoRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {


        private readonly VideoService _videoService;

        public VideosController(VideoService videoService)
        {
            _videoService = videoService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateVideo([FromBody] Video video)
        {
            try
            {
                await _videoService.AddVideoAsync(video);
                return Ok(video);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Video>> GetVideo(int id)
        {
            var video = await _videoService.GetVideoByIdAsync(id);
            if (video == null)
                return NotFound();

            return Ok(video);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Video>>> GetAllVideos()
        {
            var videos = await _videoService.GetAllVideosAsync();
            return Ok(videos);
        }

    }
}
