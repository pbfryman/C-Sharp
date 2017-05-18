using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_Gram_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double calories;
            double fatGrams;
            double fatPercent;
            double totalCalories;

            //Get user
            Console.WriteLine("Please enter the number of fat grams: ");
            fatGrams = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the number of calories: ");
            totalCalories = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            calories = fatGrams * 9;

            fatPercent = calories / totalCalories;

            //IF
            if (fatPercent < .30)
            {
                Console.WriteLine("Food is low in fat.");
            }
            else
            {
                Console.WriteLine("Food is high in fat.");
            }
        }
    }
}
