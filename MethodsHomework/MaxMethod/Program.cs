using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(MaxMethod(firstNum, secondNum, thirdNum));
        }

        static int MaxMethod(int firstNum, int secondNum, int thirdNum)
        {
            int maxNum = 0;
            if (firstNum >= secondNum)
            {
                maxNum = firstNum;
            }
            else if (secondNum >= firstNum)
            {
                maxNum = secondNum;
            }
            if (thirdNum > maxNum)
            {
                maxNum = thirdNum;
            }
            return maxNum;
        }
    }
}
