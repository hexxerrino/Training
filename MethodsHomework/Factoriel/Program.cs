using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(CountTrailingZeros(size));
        }

        static BigInteger CalculateFactorial(int size)
        {
            BigInteger factorial = 1;
            for (int i = size; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int CountTrailingZeros(int number)
        {
            int sumOfZeros = 0;
            BigInteger numberInFactorial = (CalculateFactorial(number));
            string factorialInString = numberInFactorial.ToString();

            for (int i = 0; i < factorialInString.Length; i++)
            {
                if (factorialInString[i] == '0')
                {
                    sumOfZeros += 1;
                }
                else if (factorialInString[i] != '0')
                {
                    sumOfZeros = 0;
                }
            }
            return sumOfZeros;
        }
    }
}
