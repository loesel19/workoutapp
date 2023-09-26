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
        BaseResponse<List<CategoryDto>> GetAllCategories();
    }
}
