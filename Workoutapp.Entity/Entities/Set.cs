using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Entity.Entities
{
    public class Set : BaseEntity
    {
        public double Weight { get; set; }
        public int Repetitions { get; set; }
        public DateTime Date { get; set; }
        public int ExerciseId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
        [ForeignKey("ExerciseId")]
        public virtual Exercise Exercise { get; set; }
    }
}
