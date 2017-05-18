using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Prediction
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent = .62;
            double totalSales = 4600000;
            double sales = 0;

            sales = percent * totalSales;

            Console.WriteLine("East Coast: $" + sales);
        }
    }
}
