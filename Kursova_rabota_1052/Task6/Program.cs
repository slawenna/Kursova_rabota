using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task_404");
            int n;
            do
            {
                Console.Write("Write n between [2:50]:");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 50);
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                myArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("==============");
            Console.WriteLine("a) ");
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int sum = myArray.Sum();
            if (k > n)
            {
                Console.WriteLine("There is no answer for k = {0}", k);
            }
            else
            {
                Console.WriteLine("Sum = " + sum);
            }


            Console.WriteLine("==============");
            Console.WriteLine("b) ");
            int numberOf3DigitNumbers = CountNumbers(myArray);
            Console.WriteLine("Number of 3-digit numbers with even sum of digits: " + numberOf3DigitNumbers);
            bool Is3DigitNumberSumEven(int num)
            {
                bool isSumEven = false;
                int a = num / 100 % 10;
                int b = num / 10 % 10;
                int c = num % 10;
                if ((a + b + c) % 2 == 0)
                {
                    isSumEven = true;
                }
                return isSumEven;
            }

            int CountNumbers(int[] arr)
            {
                int countNumbers = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].ToString().Length == 3 && Is3DigitNumberSumEven(arr[i]))
                    {
                        countNumbers++;
                    }
                }
                return countNumbers;
            }



        }

    }
}
