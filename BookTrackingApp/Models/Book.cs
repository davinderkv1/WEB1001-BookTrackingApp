﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingApp.Models
{
    public class Book
    {   
        [Key]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
