﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticket_Online.Areas.Admin.Models
{
    public class User
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string  Password { get; set; }

        public bool Status { get; set; }

    }
}
