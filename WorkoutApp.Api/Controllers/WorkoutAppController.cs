using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WorkoutApp.Api.Controllers
{
    public class WorkoutAppController : Controller
    {
        IServiceProvider serviceProvider;

        
        public WorkoutAppController(IServiceProvider service)
        {
            serviceProvider = service;
        }
    }
}
