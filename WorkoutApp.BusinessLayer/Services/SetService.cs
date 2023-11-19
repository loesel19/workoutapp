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
        public BaseResponse<List<SetDto>> GetSetsForUser(int userId)
        {
            try
            {
                var sets = _dbContext.Sets.Include(x => x.Exercise).ThenInclude(x => x.Category).Where(x => x.UserId == userId && !x.IsDeleted).OrderBy(x => x.Date).ToList();
                if (sets == null)
                {
                    return new BaseResponse<List<SetDto>>().Error(null, 200, $"Failed to retrieve sets for user {userId}");
                }
                return new BaseResponse<List<SetDto>>().Success(sets.ConvertAll(x => x.ToDomain()), 200, $"Successfully retrieved {sets.Count} sets for user {userId}");
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<SetDto>>().Error(null, 200, $"Failed to retrieve sets for user {userId}");
            }
        }

        public BaseResponse<SetDto> CreateSet(SetDto set)
        {
            if (set.AddedBy == null)
            {
                set.AddedBy = set.UserId;
            }
            _dbContext.Sets.Add(set.ToEntity());
            _dbContext.SaveChanges();
            var added = _dbContext.Sets.Where(x => x.Date == set.Date).FirstOrDefault();
            if (added != null)
            {
                return new BaseResponse<SetDto>().Success(added.ToDomain(), 200, "Successfully added new set.");
            }
            return new BaseResponse<SetDto>().Error(null, 200, "Failed to add new set.");
        }
    }
}
