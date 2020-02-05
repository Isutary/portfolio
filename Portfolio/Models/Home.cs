using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Home
    {
        //[Required]
        public string Title { get; set; }
        //[Required]
        public string Image { get; set; }
        //[Required]
        public string Description { get; set; }
        //[Required]
        public string FacebookLink { get; set; }
        //[Required]
        public string GithubLink { get; set; }
        //[Required]
        public string LinkedinLink { get; set; }
    }
}
