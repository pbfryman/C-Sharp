using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            const double serving = 4;
            const double calories = 300;
            double cookies;
            double totalCalories;

            //User input
            Console.WriteLine("Number of Cookies:");
            cookies = Convert.ToDouble(Console.ReadLine());

            //Math
            totalCalories = (cookies / serving) * calories;

            //Output
            Console.WriteLine("Total Calories: " + totalCalories);
        }
    }
}
