using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task_35b");
            Console.WriteLine("Enter a, b, c for: ax^2 + bx + c = 0");
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double D = b*b - 4*a*c;
            if (D < 0)
            {
                Console.WriteLine("True, there are no real roots.");
            }
            else if (D == 0)
            {
                Console.WriteLine("False, there is one real root.");
            }
            else if (D > 0)
            {
                Console.WriteLine("False, there are two real roots.");
            }
        }
    }
}
