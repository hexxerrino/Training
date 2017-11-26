using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StringsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 BigInteger[] baseNumber = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
                BigInteger baseWanted = baseNumber[0];
                BigInteger number = baseNumber[1];
                BigInteger reminder = 0;
                StringBuilder numInString = new StringBuilder();
                do
                {
                    if (number == 0)
                    {
                        break;
                    }
                    reminder = number % baseWanted;
                    number = number / baseWanted;
                    numInString.Append(reminder);
                }
                while (true);

                string answer = numInString.ToString();
                char[] charArray = answer.ToCharArray();
                Array.Reverse(charArray);
                if (charArray.Length == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(string.Join("", charArray));
                }
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }
        }
    }
}
