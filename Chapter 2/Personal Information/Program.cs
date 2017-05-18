using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Paul Blake Fryman";
            string address = "7055 Town Bluff Drive";
            string city = "Dallas";
            string state = "TX";
            int zip = 75248;
            string phone = "972 - 974 - 6999";
            string major = "Business Computer Information Systems";

            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(city + ", " + zip);
            Console.WriteLine(phone);
            Console.WriteLine(major);
        }
    }
}
