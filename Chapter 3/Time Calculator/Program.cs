using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            int minute;
            int hour;
            int day;

            //Get user input
            Console.WriteLine("Please enter a number of seconds: ");
            seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //IF
            if (seconds < 60)
            {
                Console.WriteLine("Seconds: " + seconds);
            }
            else if (seconds < 3600)
            {
                minute = seconds / 60;
                Console.WriteLine("Minutes: " + minute);
            }
            else if (seconds < 86400)
            {
                hour = seconds / 3600;
                Console.WriteLine("Hours: " + hour);
            }
            else
            {
                day = seconds / 86400;
                Console.WriteLine("Days: " + day);
            }
        }
    }
}
