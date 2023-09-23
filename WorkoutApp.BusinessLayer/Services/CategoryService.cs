using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.BusinessLayer.Dtos;
using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Services
{
    public partial class Service : IService
    {
        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
