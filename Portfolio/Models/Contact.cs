using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Contact
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public bool isRead { get; set; }
    }
}
