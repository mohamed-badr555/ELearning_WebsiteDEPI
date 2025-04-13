using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseDTOs;
using BLL.Managers.CourseManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseMananger _courseMananger;

        public CourseController(ICourseMananger courseMananger)
        {
            _courseMananger = courseMananger;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_courseMananger.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_courseMananger.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(CourseAddDto courseAddDto)
        {
            _courseMananger.Insert(courseAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, CourseUpdateDto courseUpdateDto)
        {
            _courseMananger.Update(courseUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _courseMananger.Delete(Id);
            return NoContent();
        }
    }
}
