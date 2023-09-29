using Microsoft.AspNetCore.Mvc;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Services;

namespace WorkoutApp.Api.Controllers
{
    public class SetController : WorkoutAppController
    {
        public SetController(IService service): base(service) { }

        [HttpGet]
        [Route("[controller]/user/{userId}")]
        public IActionResult GetSets(int userId)
        {
            var response = _service.GetSetsForUser(userId);
            return Json(response);
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult CreateSet([FromBody]SetDto set)
        {
            var response = _service.CreateSet(set);
            return Json(response);
        }
    }
}
