using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Factories
{
    public static class BaseFactory
    {
        public static BaseEntity ToEntity(this BaseDto dto)
        {
            BaseEntity entity = new BaseEntity();
            if (dto != null)
            {
                entity.UpdatedBy = dto.UpdatedBy;
                entity.AddedBy = dto.AddedBy;
                entity.DateAdded = dto.DateAdded;
                entity.DateUpdated = dto.DateUpdated;
                entity.Id = dto.Id;
                entity.IsDeleted = dto.IsDeleted;
            }
            return entity;
        }

        public static BaseDto ToDomain(this IEntity entity)
        {
            BaseDto dto = new BaseDto();
            if (entity != null)
            {
                dto.UpdatedBy = entity.UpdatedBy;
                dto.AddedBy = entity.AddedBy;
                dto.DateAdded = entity.DateAdded;
                dto.DateUpdated = entity.DateUpdated;
                dto.Id = entity.Id;
                dto.IsDeleted = entity.IsDeleted;
            }
            return dto;
        }
    }
}
