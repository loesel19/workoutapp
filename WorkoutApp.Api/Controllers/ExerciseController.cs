using Microsoft.AspNetCore.Mvc;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Services;

namespace WorkoutApp.Api.Controllers
{
    public class ExerciseController : WorkoutAppController
    {
        public ExerciseController(IService service) : base(service)
        {
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult CreateExercise([FromBody]ExerciseDto exercise)
        {
            var response = _service.CreateExercise(exercise);
            return Json(response);
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetExercises()
        {
            var response = _service.GetExercises();
            return Json(response);
        }

        [HttpGet]
        [Route("[controller]/category/{categoryId}")]
        public IActionResult GetExercisesForCategory([FromRoute] int categoryId)
        {
            var response = _service.GetExercisesForCategory(categoryId);
            return Json(response);
        }
    }
}
