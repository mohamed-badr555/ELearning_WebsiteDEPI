using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.CourseUnitDTOs;
using BLL.Managers.CourseUnitManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseUnitController : ControllerBase
    {
        private readonly ICourseUnitManager _courseUnitManager;

        public CourseUnitController(ICourseUnitManager courseUnitManager)
        {
            _courseUnitManager = courseUnitManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_courseUnitManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_courseUnitManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(CourseUnitAddDto courseUnitAddDto)
        {
            _courseUnitManager.Insert(courseUnitAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, CourseUnitUpdateDto courseUnitUpdateDto)
        {
            _courseUnitManager.Update(courseUnitUpdateDto);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            _courseUnitManager.Delete(Id);
            return NoContent();
        }
    }
}
