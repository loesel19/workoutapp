﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workoutapp.Entity.Entities
{
    public class User: EntityBase
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [InverseProperty("User")]
        public ICollection<Set> Sets { get; set; }
    }
}
