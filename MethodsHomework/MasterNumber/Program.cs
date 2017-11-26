using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int last = int.Parse(Console.ReadLine());
            PrintMasters(last);
        }

        static void PrintMasters(int lastMaster)
        {

            for (int i = 1; i <= lastMaster; i++)
            {
                if (CheckIfSimmetric(i) && SumOfDigits(i) % 7 == 0 && CheckIfThereIsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckIfSimmetric(int number)
        {
            string numInString = number.ToString();

            for (int i = 0; i < numInString.Length / 2; i++)
            {
                if (numInString[i] != numInString[numInString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static double SumOfDigits(int number)
        {
            string numberInString = number.ToString();
            double sum = 0;

            for (int i = 0; i < numberInString.Length; i++)
            {
                sum += int.Parse(numberInString[i].ToString());
            }

            return sum;
        }

        static bool CheckIfThereIsEvenDigit(int number)
        {
            string numberInString = number.ToString();

            for (int i = 0; i < numberInString.Length; i++)
            {
                if (int.Parse(numberInString[i].ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
