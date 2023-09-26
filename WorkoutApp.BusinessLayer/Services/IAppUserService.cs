using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Responses;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Services
{
    public partial interface IService
    {
        BaseResponse<AppUserDto> getUser(int id);
        BaseResponse<AppUserDto> signIn(AppUserDto user);
        BaseResponse<AppUserDto> createUser(AppUserDto user);
        int GetId();

    }
}
