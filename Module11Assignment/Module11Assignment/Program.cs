using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
            }
            else if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width");
                double width = Convert.ToDouble(Console.ReadLine());

                if (width > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                }
                else if (width <= 50)
                {
                    Console.WriteLine("Please enter the package height");
                    double height = Convert.ToDouble(Console.ReadLine());
                    if (height > 50)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express");
                        Console.ReadLine();
                    }
                    else if (height <= 50)
                    {
                        Console.WriteLine("Please enter the package length");
                        double length = Convert.ToDouble(Console.ReadLine());
                        if (length > 50)
                        {
                            Console.WriteLine("Package too big to be shipped via Package Express");
                            Console.ReadLine();
                        }
                        else if ((length * width * height) > 50)
                        {
                            Console.WriteLine("Package too big to be shipped via Package Express");
                            Console.ReadLine();
                        }
                        else if ((length * width * height) <= 50)
                        {
                            double totalDimension = Convert.ToDouble(length * width * height);
                            double totalPrice = Convert.ToDouble(totalDimension / 100);
                            Console.WriteLine("Your estimated total for shipping this package is: $ " + totalPrice + "");
                            Console.ReadLine();
                        }



                    }
                }
            }
        }

    }
}
