using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WorkoutApp.BusinessLayer.Services;

namespace WorkoutApp.Api.Controllers
{
    public class WorkoutAppController : Controller
    {
        public static IService _service;

        
        public WorkoutAppController(IService service)
        {
            _service = service;
        }
    }
}
