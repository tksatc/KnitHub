using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class YarnDetail
    {
        public int YarnDetailId { get; set; }
        
        [Required(ErrorMessage = "You must enter a yarn to provide the details.")]
        public int YarnId { get; set; }
        public Yarn Yarn { get; set; }

        [Display(Name = "Color")]
        public string YarnColor { get; set; }

        [Display(Name = "Color Code")]
        public string YarnColorCode { get; set; }

        [Display(Name = "Dye Lot")]
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
