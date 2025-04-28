using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseAccountDTOs;
using BLL.Managers.CourseAccountManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseAccountController : ControllerBase
    {
        private readonly ICourseAccountManager _courseAccountManager;

        public CourseAccountController(ICourseAccountManager courseAccountManager)
        {
            _courseAccountManager = courseAccountManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_courseAccountManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_courseAccountManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(CaAddDto CaAddDto)
        {
            _courseAccountManager.Insert(CaAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, CaUpdateDto CaUpdateDto)
        {
            _courseAccountManager.Update(CaUpdateDto);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            _courseAccountManager.Delete(Id);
            return NoContent();
        }
    }
}