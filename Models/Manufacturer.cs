﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        
        [Required(ErrorMessage = "Please enter the manufacturer's name")]
        [StringLength(30, ErrorMessage = "The manufacturer's name cannot exceed 30 characters.")]
        public String Name { get; set; }

        public int ProductLineId { get; set; }
        public ProductLine ProductLine { get; set; }

        [Display(Name = "Web Address")]
        public String Url { get; set; }

        public ICollection<Yarn> Yarns { get; set; }
        public ICollection<Pattern> Patterns { get; set; }
    }
}
