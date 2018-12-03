using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task_372ad");
            int n;
            do
            {
                Console.Write("Please, enter the number (1 - 50) of cities you want to compare: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 50);
            string[] Cities = new string[n];
            Console.WriteLine("Please, enter the names with upper-case letter.");
            for (int i = 0; i < Cities.Length; i++)
            {
                Console.Write("City[{0}] = ", i+1);
                Cities[i] = Console.ReadLine();              
            }
            
                bool end = Cities[n].EndsWith("ovo");
                if (Cities[n].EndsWith("ovo"))
                {
                    Console.WriteLine("{0}", end);
                }
                else
                {
                    Console.WriteLine("There is no word ending with -ovo.");
                }           
            
        }
    }
}
