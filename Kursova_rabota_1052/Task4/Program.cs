using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("122j");
            Console.WriteLine("Enter n: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x: ");
            double x = double.Parse(Console.ReadLine());

            for (int s = 1; s <= 2*n - 1; s +=1)
            {
                for (int p = 2; p < 2*n; p+=1)
                {
                    for (int z = 3; z < 2*n +1; z+=1)
                    {  
                        
                        double y = (Math.PI / 2) - x - (s * Math.Pow( x, z) / (p * z));
                        //Console.WriteLine("y = (Math.PI / 2) - x - (({0} * Math.Pow(x, {1}) / ({2} * {1}))", s++, z++, p++);
                        Console.WriteLine("y = " + y);
                        double arccosX = Math.Acos(x);
                        if (arccosX > y)
                        {
                            Console.WriteLine("ArccosX > y");
                        }
                        else if (arccosX < y)
                        {
                            Console.WriteLine("ArccosX < y");
                        }
                        else Console.WriteLine("ArccosX = y");
                     }
                }
            }
        }
    }
}
