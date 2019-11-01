using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int whichFibonacci = int.Parse(Console.ReadLine());
            PrintFibonacci(whichFibonacci);
        }

        static void PrintFibonacci(int number)
        {
            int filler = 0;
            int[] fibonacci = new int[3]
                {
                    0, 1, 1
                };

            for (int i = 1; i <= number; i++)
            {
                fibonacci[2] = fibonacci[0] + fibonacci[1];
                filler = fibonacci[1];
                fibonacci[1] = fibonacci[2];
                fibonacci[0] = filler;
            }

            Console.WriteLine(fibonacci[2]);
        }
    }
}
