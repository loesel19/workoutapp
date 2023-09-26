using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.BusinessLayer.Responses;
using WorkoutApp.BusinessLayer.Factories;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Services
{
    public partial class Service : IService
    {
        public BaseResponse<List<CategoryDto>> GetAllCategories()
        {
            var categories = _dbContext.Categories.ToList();
            if(categories == null)
            {
                return new BaseResponse<List<CategoryDto>>().Error(null, 200, "Failed to retrieve Categories");
            }
            return new BaseResponse<List<CategoryDto>>().Success(categories.ConvertAll(x => x.ToDomain()), 200, $"Successfully retrieved {categories.Count} categories.");
        }
    }
}
