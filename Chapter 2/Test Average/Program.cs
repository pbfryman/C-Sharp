using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double scoreOne;
            double scoreTwo;
            double scoreThree;
            double average;

            //User input 1
            Console.WriteLine("Score 1:");
            scoreOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //User input 2
            Console.WriteLine("Score 2:");
            scoreTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //User input 3
            Console.WriteLine("Score 3:");
            scoreThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            average = (scoreOne + scoreTwo + scoreThree) / 3;

            //Output
            Console.WriteLine("Score 1: " + scoreOne);
            Console.WriteLine("Score 2: " + scoreTwo);
            Console.WriteLine("Score 3: " + scoreThree);
            Console.WriteLine("Average: " + average);
        }
    }
}
