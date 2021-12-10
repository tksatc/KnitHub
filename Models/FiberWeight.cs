using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnitHub.Models
{
    public class FiberWeight
    {
        [Key]
        public int FiberWeightId { get; set; }
        
        [Required(ErrorMessage = "Please enter the numerical symbol for the yarn weight.")]
        [Range(1, 1, ErrorMessage = "A weight symbol is a single digit.")]
        public int Symbol { get; set; }

        [StringLength(30, ErrorMessage = "The weight descriptor cannot exceed 30 characters.")]
        [Column("Description")]
        [Display(Name = "Yarn Weight")]
        public String Name { get; set; }

        public ICollection<Yarn> Yarns { get; set; }
    }
}
