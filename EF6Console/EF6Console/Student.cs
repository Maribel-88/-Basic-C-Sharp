using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Console
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public string StudentEmail { get; set;}

        public string Section { get; set; }
    }
}
