using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Male_and_Female_Percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            double male;
            double female;
            double total;
            double malePer;
            double femalePer;

            //Get males
            Console.WriteLine("Number of males:");
            male = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Get females
            Console.WriteLine("Number of females:");
            female = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            total = male + female;
            malePer = male / total;
            femalePer = female / total;

            //Output
            Console.WriteLine("Males: " + malePer);
            Console.WriteLine("Females: " + femalePer);
        }
    }
}
