using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int currentNum = listOfIntegers[0];
            int currentCount = 0;
            int kingNum = 0;
            int kingCount = 0;

            foreach (var item in listOfIntegers)
            {
                if (currentNum == item)
                {
                    currentCount++;
                }
                else if (currentNum != item)
                {
                    currentNum = item;
                    currentCount = 1;
                }
                if (currentCount > kingCount)
                {
                    kingNum = currentNum;
                    kingCount = currentCount;
                }
            }

            for (int i = 0; i < kingCount; i++)
            {
                Console.Write($"{kingNum} ");
            }
            Console.WriteLine();
        }
    }
}
