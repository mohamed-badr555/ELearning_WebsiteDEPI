using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.ExamDTOs;
using BLL.Managers.ExamManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamManager _examManager;

        public ExamController(IExamManager examManager)
        {
            _examManager = examManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_examManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_examManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(ExamAddDto examAddDto)
        {
            _examManager.Insert(examAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, ExamUpdateDto examUpdateDto)
        {
            _examManager.Update(examUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _examManager.Delete(Id);
            return NoContent();
        }
    }
}
