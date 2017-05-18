using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Charges
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double total;
            double small = 1.10;
            double medium = 2.20;
            double large = 3.70;
            double extraLarge = 3.80;

            //User input
            Console.WriteLine("Please enter the weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //IF
            if (weight < 3)
            {
                Console.WriteLine("$" + small);
            }
            else if (weight < 7)
            {
                Console.WriteLine("$" + medium);
            }
            else if (weight < 11)
            {
                Console.WriteLine("$" + large);
            }
            else
            {
                Console.WriteLine("$" + extraLarge);
            }
        }
    }
}
