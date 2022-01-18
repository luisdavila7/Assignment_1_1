using System;

namespace Assignment_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using the Formula");
            
            Console.Write("Insert the value of a: ");
            double value_a = double.Parse(Console.ReadLine());

            Console.Write("Insert the value of b: ");
            double value_b = double.Parse(Console.ReadLine());

            Console.Write("Insert the value of c: ");
            double value_c = double.Parse(Console.ReadLine());

            Console.WriteLine("The values are {0}, {1}, {2}", value_a, value_b, value_c);

            double delta = (double)Math.Pow(value_b, 2) - (4 * value_a * value_c);

            Console.WriteLine("The values of delta are: {0}", delta);
            if(value_a != 0)
            {
                if (delta < 0)
                {
                    Console.WriteLine("The operation cannot be performed the equation has an imaginary number");

                }
                else
                {
                    double value_x1 = ((value_b * -1) + Math.Sqrt(delta)) / (2 * value_a);
                    Console.WriteLine("The value of x + are {0:F2}", (double)value_x1);

                    double value_x2 = ((value_b * -1) - Math.Sqrt(delta)) / (2 * value_a);
                    Console.WriteLine("The value of x - are {0:F2}", (double)value_x2);
                }
            }
            else
            {
                Console.WriteLine("The value of the variable a should not be 0");
            }
           
        }
    }
}
