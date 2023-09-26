using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WorkoutApp.BusinessLayer.Dtos;
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

        [HttpPost]
        [Route("[controller]/signin")]
        public IActionResult SignIn([FromBody]AppUserDto user)
        {
            var response = _service.signIn(user);
            if (response.IsSuccess)
            {
                var identity = new ClaimsIdentity(HttpContext.User.Identity);
                identity.Actor = new ClaimsIdentity();
                identity.Actor.AddClaim(new Claim("userid", response.Data.Id.ToString()));

                var principal = new ClaimsPrincipal(identity);
                Thread.CurrentPrincipal = principal;
                HttpContext.User = (ClaimsPrincipal)Thread.CurrentPrincipal;
            }
            return Json(response);
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult CreateUser([FromBody]AppUserDto user)
        {
            var response = _service.createUser(user);
            return Json(response);
        }
    }
}
