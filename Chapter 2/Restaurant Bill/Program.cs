using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            double charge;
            double tax;
            double afterTax;
            double tip;
            double meal;

            //User input
            Console.WriteLine("Meal Charge:");
            charge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            tax = (charge * .0675);
            afterTax = charge + tax;
            tip = (afterTax * .20);
            meal = charge + tax + tip;

            //Output
            Console.WriteLine("Meal: $" + charge);
            Console.WriteLine("Tax: $" + tax);
            Console.WriteLine("Tip: $" + tip);
            Console.WriteLine("Bill Total: $" + meal);
            Console.WriteLine();
        }
    }
}
