using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workoutapp.Entity.Entities
{
    public class Category : EntityBase
    {
        [Required]
        [MaxLength(50, ErrorMessage ="Category name must be 50 or fewer characters")]
        public string Name { get; set; }
    }
}
