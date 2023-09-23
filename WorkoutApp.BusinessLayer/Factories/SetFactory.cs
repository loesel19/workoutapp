using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Factories
{
    public static class SetFactory
    {
        public static SetDto ToDomain(this Set entity)
        {
            SetDto dto = (SetDto)BaseFactory.ToDomain(entity);
            dto.ExerciseId = entity.ExerciseId;
            dto.Weight = entity.Weight;
            dto.Repitions = entity.Repitions;
            dto.Date = entity.Date;
            dto.UserId = entity.UserId;

            if(entity.Exercise != null)
            {
                
            }

            return dto;

        }

        public static Set ToEntity(this SetDto dto)
        {
            Set entity = (Set)BaseFactory.ToEntity(dto);
            entity.ExerciseId = dto.ExerciseId;
            entity.Weight = dto.Weight;
            entity.Repitions = dto.Repitions;
            entity.Date = dto.Date;
            entity.UserId = dto.UserId;

            return entity;
        }
    }
}
