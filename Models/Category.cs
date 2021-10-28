using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter a category name.")]
        [StringLength(50, ErrorMessage = "Category name cannot exceed 50 characters.")]
        [RegularExpression(" ^[a - zA - Z0 - 9_] * $", ErrorMessage = "A category can contain alphanumeric characters only.")]
        public string Name { get; set; }

        public ICollection<Pattern> Patterns { get; set; }
    }
}
