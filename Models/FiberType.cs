using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class FiberType
    {
        [Key]
        public int FiberTypeId { get; set; }
       
        [Required(ErrorMessage = "Please enter the type of fiber.")]
        [StringLength(50, ErrorMessage = "A fiber type cannot exceed 50 characters.")]
        [RegularExpression(" ^[a - zA - Z0 - 9_] * $", ErrorMessage = "A fiber type can contain alphanumeric characters only.")]
        [Display(Name = "Yarn Type")]
        public String Name { get; set; }

        public ICollection<Yarn> Yarns { get; set; }
    }
}
