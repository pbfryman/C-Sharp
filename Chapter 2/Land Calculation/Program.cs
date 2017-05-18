using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double land = 389767;
            double squareFeet = 43560;
            double acres = 0;

            acres = land / squareFeet;

            Console.WriteLine("Acres: " + acres);
        }
    }
}
