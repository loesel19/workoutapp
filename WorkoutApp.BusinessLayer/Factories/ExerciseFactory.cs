using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Factories
{
    public static class ExerciseFactory
    {
        public static ExerciseDto ToDomain(this Exercise entity)
        {
            if(entity == null)
            {
                return null;
            }

            ExerciseDto dto = BaseFactory.ToDomain<ExerciseDto>(entity);
            dto.CategoryId = entity.CategoryId;
            dto.Name = entity.Name;

            if(entity.Category != null)
            {
                dto.Category = entity.Category.ToDomain();
            }
            return dto;
        }

        public static Exercise ToEntity(this ExerciseDto dto)
        {
            if(dto == null)
            {
                return null;
            }

            Exercise exercise = BaseFactory.ToEntity<Exercise>(dto);
            exercise.CategoryId = dto.CategoryId;
            exercise.Name = dto.Name;

            return exercise;
        }


    }
}
