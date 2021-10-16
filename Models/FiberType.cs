using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class FiberType
    {
        public int FiberTypeId { get; set; }
        [Required(ErrorMessage = "Please enter the type of fiber.")]
        public String Name { get; set; }

        public ICollection<Yarn> Yarns { get; set; }
    }
}
