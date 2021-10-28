using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class Yarn
    {
        [Key]
        public int YarnId { get; set; }
        [Required(ErrorMessage = "Please enter the manufacturer")]

        public int ManufacturerId { get; set; }

        [Display(Name = "Producer")]
        public Manufacturer Manufacturer { get; set; }

        [Required(ErrorMessage = "Please enter the name of the yarn.")]
        [StringLength(30, ErrorMessage = "The yarn name cannot exceed 30 characters.")]
        public String Name { get; set; }

        public int FiberTypeId { get; set; }

        [Display(Name = "Fiber Type")]
        public FiberType FiberType { get; set; }
        [Required(ErrorMessage = "Please enter the yarn weight, 0-7.")]
        [Range(1, 1, ErrorMessage = "The yarn weight is a single digit between 0 and 7.")]

        public int FiberWeightId { get; set; }
       [Display(Name = "Fiber Weight")]
        public FiberWeight FiberWeight { get; set; }

        [Display(Name = "Yards in Skein")]
        [Range(1, 3000, ErrorMessage = "A skein, hank, ball, or cone of yarn cannot exceed 3000 yards in length.")]
        public int SkeinYardage { get; set; }

        [Display(Name = "Skein Weight")]
        public double SkeinWeight { get; set; }

        [Display(Name = "Updated")]
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public ICollection<YarnDetail> YarnDetails { get; set; }
    }
}
