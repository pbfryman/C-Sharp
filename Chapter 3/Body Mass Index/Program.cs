using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_Mass_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int weight;
            int bmi;
            int underweight;
            int optimal;
            int overweight;

            //Get user input
            Console.WriteLine("Please enter your height:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter your weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Calculate BMI
            bmi = weight * 703 / (height * height);

            //If statement
            if (bmi < 18.5)
            {
                Console.WriteLine("You are considered underweight.");
            }
            else if (bmi > 25)
            {
                Console.WriteLine("You are considered overweight.");
            }
            else
            {
                Console.WriteLine("You are considered optimal.");
            }
        }
    }
}
