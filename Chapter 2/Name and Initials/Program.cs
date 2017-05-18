using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_and_Initials
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Paul";
            string middleName = "Blake";
            string lastName = "Fryman";
            char firstInitial = 'P';
            char middleInitial = 'B';
            char lastInitial = 'F';

            Console.WriteLine(firstName + " " + middleName + " " + lastName + " ");
            Console.WriteLine(firstInitial + " " + middleInitial + " " + lastInitial);
        }
    }
}
