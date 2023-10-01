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
            //IQuittable Resigned = new Employee() { firstName = "Maribel", lastName = "Pajares", Id = 1234 };
            //Resigned.Quit();
            //Console.ReadLine();
            Employee employee1 = new Employee() { firstName = "Maribel", lastName = "Pajares", Id = 1234 };
            Employee employee2 = new Employee() { firstName = "Maribel", lastName = "Pajares", Id = 2545 };

            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("This person is a former employee");
            }
            else if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("New Employee");
            }
            Console.ReadLine();


        }


    }
}
