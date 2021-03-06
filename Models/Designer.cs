using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnitHub.Models
{
    public class Designer
    {
        [Key]
        public int DesignerId { get; set; }
        
        [StringLength(20, ErrorMessage = "The first name cannot exceed 20 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter a last name for the designer.")]
        [StringLength(20, ErrorMessage = "The last name cannot exceed 20 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public ICollection<Pattern> Patterns { get; set; }
    }
}
