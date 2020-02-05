using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Education
    {
        public Guid ID { get; set; }
        //[Required]
        public string Title { get; set; }
        //[Required]
        public string Description { get; set; }
        //[Required]
        public string Image { get; set; }
        //[Required]
        public string OrderLink { get; set; }
    }
}
