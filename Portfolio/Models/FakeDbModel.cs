using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class FakeDbModel
    {
        public Home home { get; set; }
        public List<Education> education { get; set; }
        public List<Projects> projects { get; set; }
        public List<Contact> contact { get; set; }
    }
}
