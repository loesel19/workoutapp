using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Factories
{
    public static class SetFactory
    {
        public static SetDto ToDomain(this Set entity)
        {
            if(entity == null)
            {
                return null;
            }

            SetDto dto = BaseFactory.ToDomain<SetDto>(entity);
            dto.ExerciseId = entity.ExerciseId;
            dto.Weight = entity.Weight;
            dto.Repetitions = entity.Repetitions;
            dto.Date = entity.Date;
            dto.UserId = entity.UserId;

            if(entity.Exercise != null)
            {
                
            }

            return dto;

        }

        public static Set ToEntity(this SetDto dto)
        {
            if(dto == null)
            {
                return null;
            }

            Set entity = BaseFactory.ToEntity<Set>(dto);
            entity.ExerciseId = dto.ExerciseId;
            entity.Weight = dto.Weight;
            entity.Repetitions = dto.Repetitions;
            entity.Date = dto.Date;
            entity.UserId = dto.UserId;

            return entity;
        }
    }
}
