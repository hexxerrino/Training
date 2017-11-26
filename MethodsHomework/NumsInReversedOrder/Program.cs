using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintReversed(number);
        }

        static void PrintReversed(string number)
        {
            char[] reversedNumber = new char[number.Length];

            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedNumber[j] = number[i];
            }

            Console.WriteLine(reversedNumber);
        }
    }
}
