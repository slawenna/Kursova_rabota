using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task_200");
            Console.WriteLine("ax + by = c");
            Console.WriteLine("dx + ey = f");
            Console.WriteLine("Write a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Write d:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Write e:");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Write f:");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("x = d1/det, y = d2/det");           
            double det = (a * e) - (d * b);
            double d1 = (c * e) - (f * b);
            double d2 = (a * f) - (d * c);
            Console.WriteLine("det = {0}", det);
            Console.WriteLine("d1 = {0}", d1);
            Console.WriteLine("d2 = {0}", d2);
            Console.WriteLine("x = {0}, y = {1}", d1 / det, d2 / det);
            
            
            
        }
    }
}
