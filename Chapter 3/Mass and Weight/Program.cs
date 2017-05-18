using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass_and_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass;
            double weight;

            //Get user input
            Console.WriteLine("Please enter the object's mass: ");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            weight = mass * 9.8;

            //If
            if (weight < 10)
            {
                Console.WriteLine("Object is too light.");
            }
            else if (weight < 1000)
            {
                Console.WriteLine("Object is perfect.");
            }
            else
            {
                Console.WriteLine("Object is too heavy.");
            }
        }
    }
}
