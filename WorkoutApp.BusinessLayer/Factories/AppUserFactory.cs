using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Factories
{
    public static class AppUserFactory
    {
        public static AppUserDto ToDomain(this AppUser entity)
        {
            if (entity == null)
            {
                return null;
            }

            AppUserDto dto = BaseFactory.ToDomain<AppUserDto>(entity);
            dto.Username = entity.Username;
            dto.Password = entity.Password;
            dto.Email = entity.Email;
            
            return dto;
        }

        public static AppUser ToEntity(this AppUserDto dto)
        {
            if(dto == null)
            {
                return null;
            }

            AppUser entity = BaseFactory.ToEntity<AppUser>(dto);
            entity.Email = dto.Email;
            entity.Password = dto.Password;
            entity.Username = dto.Username;

            return entity;
        }
    }
}
