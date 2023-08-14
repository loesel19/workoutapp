using Microsoft.AspNetCore.Mvc;

namespace WorkoutApp.Api.Controllers
{
    public class SetController : WorkoutAppController
    {
        public SetController(IServiceProvider service): base(service) { }

        [HttpGet]
        [Route("[controller]/{userId}")]
        public IActionResult GetSets()
        {
            return new ContentResult { Content = "yurr" };
        }
    }
}
