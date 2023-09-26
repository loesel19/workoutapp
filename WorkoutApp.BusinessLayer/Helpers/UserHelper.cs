using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;

namespace WorkoutApp.BusinessLayer.Helpers
{
    public class UserHelper
    {
        public int GetId()
        {
            var claimsUser = Thread.CurrentPrincipal.Identity as ClaimsIdentity;
            if (int.TryParse(claimsUser.Actor.Claims.Where(x => x.Type == "userid").FirstOrDefault().Value, out int id))
            {
                return id;
            }
            else
            {
                return -1;
            }
        }
    }
}
