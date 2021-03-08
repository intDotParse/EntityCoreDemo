using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCoreDemo.Models
{
    public class Grade
    {
        //scalar
        public int GradeID { get; set; }
        public int Rating  { get; set; }
        public string  Subject { get; set; }

        //collection
        public ICollection<Student> Students { get; set; }
    }
}
