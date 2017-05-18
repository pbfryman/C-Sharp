using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuit_Board_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent;
            double price;
            double profit;

            //User input
            Console.WriteLine("Retail Price:");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Math
            percent = price * .4;
            profit = price - percent;

            //Output
            Console.WriteLine("Profit: $" + profit);
        }
    }
}
