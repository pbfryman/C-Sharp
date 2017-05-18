using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 99;
            double packages;
            double discount;
            double total;

            //User input
            Console.WriteLine("Please enter number of packages: ");
            packages = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //IF
            if (packages < 10)
            {
                total = packages * price;
                discount = 0;
                Console.WriteLine("Discount: $" + discount);
                Console.WriteLine("Total: $" + total);
            }
            else if (packages < 20)
            {
                total = packages * price;
                discount = total * .20;
                Console.WriteLine("Discount: $" + discount);
                Console.WriteLine("Total: $" + total);
            }
            else if (packages < 50)
            {
                total = packages * price;
                discount = total * .30;
                Console.WriteLine("Discount: $" + discount);
                Console.WriteLine("Total: $" + total);
            }
            else if (packages < 100)
            {
                total = packages * price;
                discount = total * .40;
                Console.WriteLine("Discount: $" + discount);
                Console.WriteLine("Total: $" + total);
            }
            else
            {
                total = packages * price;
                discount = total * .50;
                Console.WriteLine("Discount: $" + discount);
                Console.WriteLine("Total: $" + total);
            }
        }
    }
}
