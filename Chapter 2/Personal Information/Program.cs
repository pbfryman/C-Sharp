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
            string name = "John Jacobs";
            string address = "705 Street Name Drive";
            string city = "City";
            string state = "ST";
            int zip = 79779;
            string phone = "111 - 111 - 1111";
            string major = "Business Computer Information Systems";

            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(city + ", " + zip);
            Console.WriteLine(phone);
            Console.WriteLine(major);
        }
    }
}
