using Microsoft.AspNetCore.Mvc;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Services;

namespace WorkoutApp.Api.Controllers
{
    public class CategoryController : WorkoutAppController
    {
        public CategoryController(IService service) : base(service)
        {
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetCategories()
        {
            var categories = _service.GetAllCategories();
            return Json(categories);
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult CreateCategory([FromBody]CategoryDto category) 
        {
            var newCategory = _service.CreateCategory(category);
            return Json(newCategory);
        }
    }
}
