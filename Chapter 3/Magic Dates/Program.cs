using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            int day;
            int year;

            //User input
            Console.WriteLine("Please enter a month: (e.g., 06 or 6)");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter a day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter a year: (e.g., 99)");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Do math
            if (month * day == year)
            {
                Console.WriteLine("This is a magical date!");
            }
            else
            {
                Console.WriteLine("This date is not magical.");
            }
        }
    }
}
