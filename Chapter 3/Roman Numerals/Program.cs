using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;

            //User input
            Console.WriteLine("Please enter a number between 1 and 10:");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (number == 1)
            {
                Console.WriteLine("I");
            }
            else if (number == 2)
            {
                Console.WriteLine("II");
            }
            else if (number == 3)
            {
                Console.WriteLine("III");
            }
            else if (number == 4)
            {
                Console.WriteLine("IV");
            }
            else if (number == 5)
            {
                Console.WriteLine("V");
            }
            else if (number == 6)
            {
                Console.WriteLine("VI");
            }
            else if (number == 7)
            {
                Console.WriteLine("VII");
            }
            else if (number == 8)
            {
                Console.WriteLine("VIII");
            }
            else if (number == 9)
            {
                Console.WriteLine("IX");
            }
            else if (number == 10)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 10");
            }
        }
    }
}
