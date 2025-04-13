using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.VideoCommentDTOs;
using BLL.Managers.VideoCommentManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoCommentController : ControllerBase
    {
        private readonly IVideoCommentManager _videoCommentManager;

        public VideoCommentController(IVideoCommentManager videoCommentManager)
        {
            _videoCommentManager = videoCommentManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_videoCommentManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_videoCommentManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(VcAddDto VcAddDto)
        {
            _videoCommentManager.Insert(VcAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, VcUpdateDto VcUpdateDto)
        {
            _videoCommentManager.Update(VcUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _videoCommentManager.Delete(Id);
            return NoContent();
        }
    }
}
