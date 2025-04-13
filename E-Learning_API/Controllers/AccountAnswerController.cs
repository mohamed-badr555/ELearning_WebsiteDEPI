using BLL.DTOs.AccountAnswerDTO;
using BLL.DTOs.CategoryDTOs;
using BLL.Managers.AccountAnswerManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountAnswerController : ControllerBase
    {
        private readonly IAccountAnswerManager _accountAnswerManager;

        public AccountAnswerController(IAccountAnswerManager accountAnswerManager)
        {
            _accountAnswerManager = accountAnswerManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_accountAnswerManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_accountAnswerManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(AaAddDto AaAddDto)
        {
            _accountAnswerManager.Insert(AaAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, AaUpdateDto AaUpdateDto)
        {
            _accountAnswerManager.Update(AaUpdateDto);
            return NoContent();
        }
        public ActionResult Delete(int Id)
        {
            _accountAnswerManager.Delete(Id);
            return NoContent();
        }
    }
}