﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class WearableSize
    {
        [Key]
        public int WearableSizeId { get; set; }
        
        [Required(ErrorMessage = "Please enter a size name/description.")]
        [StringLength(10, ErrorMessage = "Size description cannot exceed 10 characters.")]
        public string Name { get; set; }
    }
}
