using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class YarnDetail
    {
        [Key]
        public int YarnDetailId { get; set; }
        
        [Required(ErrorMessage = "You must enter a yarn to provide the details.")]
        public int YarnId { get; set; }
        public Yarn Yarn { get; set; }

        [Display(Name = "Color")]
        [StringLength(30, ErrorMessage = "A color description cannot exceed 30 characters.")]
        public string YarnColor { get; set; }

        [Display(Name = "Color Code")]
        [StringLength(20, ErrorMessage = "The producer's color code cannot exceed 20 characters.")]
        public string YarnColorCode { get; set; }

        [Display(Name = "Dye Lot")]
        [StringLength(20, ErrorMessage = "The producer's dye lot code cannot exceed 20 characters.")]
        public string YarnColorLot { get; set; }

        [Display(Name = "Number of Skeins")]
        public double QuantityOfSkeins { get; set; }

        [Display(Name = "Updated")]
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public double? CalcTotalYardage()
        {
            double? totalYardageCalculation = Yarn.SkeinYardage * QuantityOfSkeins;
            return totalYardageCalculation;
        }
    }
}
