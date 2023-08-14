using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workoutapp.Entity.Entities
{
    public class Set : EntityBase
    {
        [MaxLength(50, ErrorMessage="Set name must be 50 or fewer characters")]
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Repitions { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}
