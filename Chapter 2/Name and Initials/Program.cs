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
            string firstName = "John";
            string middleName = "Bill";
            string lastName = "Jacobs";
            char firstInitial = 'J';
            char middleInitial = 'B';
            char lastInitial = 'J';

            Console.WriteLine(firstName + " " + middleName + " " + lastName + " ");
            Console.WriteLine(firstInitial + " " + middleInitial + " " + lastInitial);
        }
    }
}
