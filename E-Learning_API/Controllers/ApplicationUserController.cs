using BLL.DTOs.ApplicationUserDTOs;
using BLL.DTOs.CategoryDTOs;
using BLL.Managers.ApplicationUserManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserManager _applicationUserManager;

        public ApplicationUserController(IApplicationUserManager applicationUserManager)
        {
            _applicationUserManager = applicationUserManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_applicationUserManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_applicationUserManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(AuAddDto AuAddDto)
        {
            _applicationUserManager.Insert(AuAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, AuUpdateDto AuUpdateDto)
        {
            _applicationUserManager.Update(AuUpdateDto);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            _applicationUserManager.Delete(Id);
            return NoContent();
        }
    }
}
