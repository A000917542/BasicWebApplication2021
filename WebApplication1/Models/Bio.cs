using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Bio
    {
        [Required]
        [StringLength(128, MinimumLength = 8)]
        [Display(Name = "Full Name",Description = "Please enter your full name.")]
        public string Name { get; set; }

        [Required]
        [Url]
        public string Image { set; get; }

        [StringLength(64)]
        [CreditCard]
        public string Position { get; set; }

       
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
