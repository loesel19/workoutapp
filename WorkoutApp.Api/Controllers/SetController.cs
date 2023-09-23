using Microsoft.AspNetCore.Mvc;
using WorkoutApp.BusinessLayer.Services;

namespace WorkoutApp.Api.Controllers
{
    public class SetController : WorkoutAppController
    {
        public SetController(IService service): base(service) { }

        [HttpGet]
        [Route("[controller]/{userId}")]
        public IActionResult GetSets()
        {
            return new ContentResult { Content = "yurr" };
        }
    }
}
