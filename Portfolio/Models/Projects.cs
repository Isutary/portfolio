using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Projects
    {
        public Guid ID { get; set; }
        //[Required]
        public string Title { get; set; }
        //[Required]
        public string Description { get; set; }
        //[Required]
        public string GithubLink { get; set; }
        public string Website { get; set; }
    }
}
