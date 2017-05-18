using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchase;
            double state;
            double county;
            double total;

            //Get user input
            Console.WriteLine("Purchase Amount:");
            purchase = Convert.ToDouble(Console.ReadLine());

            //Math
            state = purchase * .04;
            county = purchase * .02;
            total = purchase + state + county;

            //Display
            Console.WriteLine();
            Console.WriteLine("Purchase: $" + purchase);
            Console.WriteLine("State Tax: $" + state);
            Console.WriteLine("County Tax: $" + county);
            Console.WriteLine("Total: $" + total);
        }
    }
}
