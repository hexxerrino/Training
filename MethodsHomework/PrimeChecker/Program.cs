using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long prime = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(prime));
        }

        static bool IsPrime(long number)
        {
            if (number == 2)
            {
                return true;
            }

            if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
