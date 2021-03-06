using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class SkillLevel
    {
        [Key]
        public int SkillLevelId { get; set; }

        [Required(ErrorMessage = "Please enter a skill level.")]
        [MaxLength(50, ErrorMessage = "Skill Level must be between 1 and 50 characters.")]
        public string Level { get; set; }

        public ICollection<Pattern> Patterns { get; set; }
    }
}
