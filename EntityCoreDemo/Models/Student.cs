using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCoreDemo.Models
{
    public class Student
    {
        //scalar
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //navigation
        public Grade Grade { get; set; }

    }
}
