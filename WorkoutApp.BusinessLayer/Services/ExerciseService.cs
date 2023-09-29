using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Factories;
using WorkoutApp.BusinessLayer.Responses;

namespace WorkoutApp.BusinessLayer.Services
{
    public partial class Service : IService
    {
        public BaseResponse<ExerciseDto> CreateExercise(ExerciseDto exercise)
        {
            var existing = _dbContext.Exercises.FirstOrDefault(x => x.Name.ToLower() == exercise.Name.ToLower());
            if (existing != null)
            {
                return new BaseResponse<ExerciseDto>().Error(null, 200, $"An exercise with name {exercise.Name} already exists.");
            }
            exercise.AddedBy = GetId();
            _dbContext.Exercises.Add(exercise.ToEntity());
            _dbContext.SaveChanges();
            existing = _dbContext.Exercises.FirstOrDefault(x => x.Name.ToLower() == exercise.Name.ToLower());
            if (existing != null)
            {
                return new BaseResponse<ExerciseDto>().Success(existing.ToDomain(), 200, $"Successfully added exercise {exercise.Name}");
            }
            return new BaseResponse<ExerciseDto>().Error(null, 200, $"Failed to add new Exercise");

        }

        public BaseResponse<List<ExerciseDto>> GetExercises()
        {
            var exercises = _dbContext.Exercises.Include(x => x.Category).Where(x => !x.IsDeleted).ToList().ConvertAll(x => x.ToDomain());
            if(exercises == null)
            {
                return new BaseResponse<List<ExerciseDto>>().Error(null, 200, "Failed to retrieve exercises.");
            }
            return new BaseResponse<List<ExerciseDto>>().Success(exercises, 200, $"Successfully retrieved {exercises.Count()} exercises.");
        }

        public BaseResponse<List<ExerciseDto>> GetExercisesForCategory(int categoryId)
        {
            var exercises = _dbContext.Exercises.Include(x => x.Category).Where(x => !x.IsDeleted && x.CategoryId == categoryId).ToList().ConvertAll(x => x.ToDomain());
            if (exercises == null)
            {
                return new BaseResponse<List<ExerciseDto>>().Error(null, 200, "Failed to retrieve exercises.");
            }
            return new BaseResponse<List<ExerciseDto>>().Success(exercises, 200, $"Successfully retrieved {exercises.Count()} exercises for category {categoryId}");
        }
    }
}
