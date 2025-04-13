using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.VideoDTOs;
using BLL.Managers.VideoManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoManager _videoManager;

        public VideoController(IVideoManager videoManager)
        {
            _videoManager = videoManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_videoManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_videoManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(VideoAddDto videoAddDto)
        {
            _videoManager.Insert(videoAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, VideoUpdateDto videoUpdateDto)
        {
            _videoManager.Update(videoUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _videoManager.Delete(Id);
            return NoContent();
        }
    }
}
