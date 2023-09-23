using Microsoft.AspNetCore.Mvc;
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
    }
}
