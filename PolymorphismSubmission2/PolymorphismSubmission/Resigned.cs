using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
   public  class Resigned
    {
      public List<Resigned> Employees { get; set; }

      public string firstName { get; set; }

      public string lastName { get; set; }

      public int Id { get; set; }

     public void ListEmployee()
        {
            Console.WriteLine("Resigned Employees");
           ListEmployee();
        }

        


    }
}
