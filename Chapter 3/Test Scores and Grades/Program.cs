using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Scores_and_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int testOne;
            int testTwo;
            int testThree;
            int testAverage;

            //Get user input
            Console.WriteLine("Test score one: ");
            testOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Test score two: ");
            testTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Test score three: ");
            testThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Math
            testAverage = (testOne + testTwo + testThree) / 3;

            //If statement
            if (testAverage > 89)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (testAverage > 79)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (testAverage > 69)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (testAverage > 59)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
            }
        }
    }
}
