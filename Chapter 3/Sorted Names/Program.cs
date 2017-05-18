using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Charlie");
            list.Add("Leslie");
            list.Add("Andy");

            //Sort
            list.Sort();

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
