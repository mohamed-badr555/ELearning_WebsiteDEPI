using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.QuestionDTOs;
using BLL.Managers.QuestionManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionManager _questionManager;

        public QuestionController(IQuestionManager questionManager)
        {
            _questionManager = questionManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_questionManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_questionManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(QuestionAddDto questionAddDto)
        {
            _questionManager.Insert(questionAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, QuestionUpdateDto questionUpdateDto)
        {
            _questionManager.Update(questionUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _questionManager.Delete(Id);
            return NoContent();
        }
    }
}
