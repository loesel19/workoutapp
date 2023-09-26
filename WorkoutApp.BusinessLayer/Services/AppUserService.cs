using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Factories;
using WorkoutApp.BusinessLayer.Helpers;
using WorkoutApp.BusinessLayer.Responses;
using WorkoutApp.Entity;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Services
{
    public partial class Service : IService
    {
        private readonly DatabaseContext _dbContext;

        public Service(DatabaseContext context) { 
            _dbContext = context;
        }

        public BaseResponse<AppUserDto>? getUser(int id)
        {
            var user = _dbContext.AppUsers.FirstOrDefault(u => u.Id == id);
            
            if(user == null)
            {
                return new BaseResponse<AppUserDto>().Success(null, 200, $"no user with id {id} can be found.");
            }
            return new BaseResponse<AppUserDto>().Success(user.ToDomain(), 200, $"Successfully retrieved user {user.Username}.");
        }

        public BaseResponse<AppUserDto> signIn(AppUserDto userInfo)
        {
            var userhash = StringHelper.GetHash(userInfo.Username);
            var passwordhash = StringHelper.GetHash(userInfo.Password);
            var user = _dbContext.AppUsers.Where(x => x.Username == userhash).FirstOrDefault();
            if(user == null)
            {
                return new BaseResponse<AppUserDto>().Error(null, 200, $"No user found with username '{userInfo.Username}'.");
            }
            if(user.Password != passwordhash)
            {
                return new BaseResponse<AppUserDto>().Error(null, 200, $"Invalid password for user {userInfo.Username}.");
            }

            return new BaseResponse<AppUserDto>().Success(user.ToDomain(), 200, $"Successfully signed in as user '{userInfo.Username}'");
        }
        
        public BaseResponse<AppUserDto> createUser(AppUserDto user)
        {
            var existingUser = _dbContext.AppUsers.FirstOrDefault(x => x.Username == StringHelper.GetHash(user.Username));
            if(existingUser != null)
            {
                return new BaseResponse<AppUserDto>().Error(null, 200, $"Provided username is not available.");
            }
            //encrypt username and password
            user.Username = StringHelper.GetHash(user.Username);
            user.Password = StringHelper.GetHash(user.Password);
            user.AddedBy = -1;
            
            _dbContext.AppUsers.Add(user.ToEntity());
            _dbContext.SaveChanges();
            var newUser = _dbContext.AppUsers.FirstOrDefault(x => x.Username == user.Username);
            return new BaseResponse<AppUserDto>().Success(newUser.ToDomain(), 200, $"Successfully created new user.");
        }

        public int GetId()
        {
            return new UserHelper().GetId();
        }

    }
}
