using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
     class Program
    {
        static void Main(string[] args)
        {
            IQuittable Resigned = new Employee() { firstName = "Maribel", lastName = "Pajares", Id = 1234 };
            Resigned.Quit();
            Console.ReadLine();
        }
    }
}
