using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunction
{
   class Program
    {
        static void Main(string[] args)
        {
            //Instatiating the class
            MathOperations1 Math101 = new MathOperations1();
            Console.WriteLine("Please enter an integer");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer");
            int y = Convert.ToInt32(Console.ReadLine());
            Math101.MathOperation(x, y);
            Console.ReadKey();

        }
        

        
    }
}
