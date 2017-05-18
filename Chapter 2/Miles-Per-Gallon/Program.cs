using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_Per_Gallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            //User input
            Console.WriteLine("How many miles?");
            miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How many gallons?");
            gallons = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            mpg = miles / gallons;

            //Output
            Console.WriteLine("MPG: " + mpg);
        }
    }
}
