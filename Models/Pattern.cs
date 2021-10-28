﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class Pattern
    {
        [Key]
        public int PatternId { get; set; }

        [Required(ErrorMessage = "Please enter a name for the pattern.")]
        [StringLength(50, ErrorMessage = "Pattern name cannot exceed 50 characters.")]
        public string Name { get; set; }

        public int ManufacturerId { get; set; }

        [Display(Name = "Publisher")]
        public Manufacturer Manufacturer { get; set; }

        public int DesignerId { get; set; }
        public Designer Designer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SkillLevelId { get; set; }

        [Display(Name = "Skill Level")]
        public SkillLevel SkillLevel { get; set; }

        [Display(Name = "Storage Location")]
        [StringLength(50, ErrorMessage = "A storage location cannot exceed 50 characters.")]
        public string StorageLocation { get; set; }

        [Display(Name = "Updated")]
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public ICollection<PatternDetail> PatternDetails { get; set; }
    }
}
