using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            //Get user input
            Console.WriteLine("Please enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //While
            while (num >=1)
            {
                sum += num;
                num--;
            }
            Console.WriteLine(sum);
        }
    }
}
