using BLL.DTOs.CategoryDTOs;
using BLL.DTOs.QuestionChoiceDTOs;
using BLL.Managers.QuestionChoiceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionChoiceController : ControllerBase
    {
        private readonly IQuestionChoiceManager _questionChoiceManager;

        public QuestionChoiceController(IQuestionChoiceManager questionChoiceManager)
        {
            _questionChoiceManager = questionChoiceManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_questionChoiceManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_questionChoiceManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(QcAddDto qcAddDto)
        {
            _questionChoiceManager.Insert(qcAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, QcUpdateDto qcUpdateDto)
        {
            _questionChoiceManager.Update(qcUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _questionChoiceManager.Delete(Id);
            return NoContent();
        }
    }
}
