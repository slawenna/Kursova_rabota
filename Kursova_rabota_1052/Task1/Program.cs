using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My number is 2052");
            Console.WriteLine("2052 to binary: {0}.", Convert.ToString(2052, 2));
            Console.WriteLine("2052 to octal: {0}.", Convert.ToString(2052, 8));
            Console.WriteLine("2052 to hexadecimal: {0}", Convert.ToString(2052, 16));


        }
    }
}
