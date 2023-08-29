using System;


namespace MethodClassAssignSubmission
{
     class Program
    {
        static void Main(string[] args)
        {
            //Instatiate MathOperations class
            MathOperations mathOp1 = new MathOperations();
            //Ask the user to provide first parameter
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int results = mathOp1.MathOperation(num1);
            Console.WriteLine(num1 + " x " + " 10 " + " = "+ results);
            //Ask the user to enter a second number
            Console.WriteLine("Please enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have entered " + num2);

            
            Console.ReadLine();
            
        }
    }
}
