using Microsoft.AspNetCore.Mvc;
using WorkoutApp.BusinessLayer.Services;

namespace WorkoutApp.Api.Controllers
{
    public class UserController : WorkoutAppController
    {
        public UserController(IService serviceProvider) : base(serviceProvider) { 

        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public IActionResult GetUser([FromRoute]int id)
        {
            var user = _service.getUser(id);
            return Json(user);
        }
    }
}
