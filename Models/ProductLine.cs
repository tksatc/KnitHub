using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class ProductLine
    {
        [Key]
        public int ProductLineId { get; set; }
        
        [Required(ErrorMessage = "Please enter a name of the product line.")]
        [StringLength(20, ErrorMessage = "A product line name cannot exceed 20 characters.")]
        public string Name { get; set; }

        public ICollection<Manufacturer> Manufacturers { get; set; }
    }
}
