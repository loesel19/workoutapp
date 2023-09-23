using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.BusinessLayer.Dtos
{
    public class ExerciseDto : BaseDto
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public CategoryDto? Category { get; set; }
    }
}
