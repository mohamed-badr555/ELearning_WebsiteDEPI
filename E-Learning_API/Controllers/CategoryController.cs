using BLL.DTOs.CategoryDTOs;
using BLL.Managers.CategoryManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_categoryManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_categoryManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(CategoryAddDto categoryAddDto)
        {
            _categoryManager.Insert(categoryAddDto);
            return NoContent();
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, CategoryUpdateDto categoryUpdateDto)
        {
            _categoryManager.Update(categoryUpdateDto);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            _categoryManager.Delete(Id);
            return NoContent();
        }
    }
}
