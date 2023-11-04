using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
  class Program
    {
        static void Main(string[] args)
        {
            
            bool validYear = false;
            int BirthYear = 0;
            while(!validYear) 
            {
                try
                {
                    Console.WriteLine("Enter your year of birth.");
                    validYear = int.TryParse(Console.ReadLine(), out BirthYear);
                    if (!validYear) Console.WriteLine("Please enter digits only, no decimals.");

                    Console.ReadLine();
                }
                catch (Exception) 
                {
                    Console.WriteLine("Please enter a valid year.");
                    Console.ReadLine() ;
                    return;
                }

            }
        }
    }
}
