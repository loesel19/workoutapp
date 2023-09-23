using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Entity.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public int UpdatedBy { get; set; }
        public int AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
