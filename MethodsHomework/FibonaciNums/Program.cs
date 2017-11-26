using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int whichFibonaci = int.Parse(Console.ReadLine());
            PrintFibonaci(whichFibonaci);
        }

        static void PrintFibonaci(int number)
        {
            int filler = 0;
            int[] fibonaci = new int[3]
                {
                    0, 1, 1
                };

            for (int i = 1; i <= number; i++)
            {
                fibonaci[2] = fibonaci[0] + fibonaci[1];
                filler = fibonaci[1];
                fibonaci[1] = fibonaci[2];
                fibonaci[0] = filler;
            }

            Console.WriteLine(fibonaci[2]);
        }
    }
}
