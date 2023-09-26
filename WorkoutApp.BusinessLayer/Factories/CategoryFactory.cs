using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Factories
{
    public static class CategoryFactory
    {
        public static CategoryDto ToDomain(this Category entity)
        {
            if(entity == null)
            {
                return null;
            }

            CategoryDto dto = BaseFactory.ToDomain<CategoryDto>(entity);
            dto.Name = entity.Name;
            return dto;
        }
        
        public static Category ToEntity(this CategoryDto dto)
        {
            if(dto == null)
            {
                return null;
            }

            Category entity = BaseFactory.ToEntity<Category>(dto);
            entity.Name = dto.Name;
            return entity;
        }

    }


}
