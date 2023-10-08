using WorkoutApp.Entity.Entities;

namespace WorkoutApp.BusinessLayer.Dtos
{
    public class SetDto : BaseDto
    {
        public double Weight { get; set; }
        public int Repetitions { get; set; }
        public DateTime Date { get; set; }
        public int ExerciseId { get; set; }
        public int UserId { get; set; }
        
        public AppUserDto? User { get; set; }
        public ExerciseDto? Exercise { get; set; }

        public double OneRepMax { get
            {
                return Weight / (1.0278 - (0.0278 * Repetitions)); //1RM calculation using the Brzycki Equation
            } 
        }
    }
}