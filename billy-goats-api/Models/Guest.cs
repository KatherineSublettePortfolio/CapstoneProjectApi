﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BillyGoats.Api.Models
{
    public class Guest : ModelBase
    {
        [Required]
        [MaxLength(75)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(75)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(75)]
        public string Email { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
