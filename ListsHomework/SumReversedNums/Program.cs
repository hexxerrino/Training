using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayOfNums = Console.ReadLine().Split(' ').ToArray();
            double sum = 0;
            for (int i = 0; i < ArrayOfNums.Length; i++)
            {
                ArrayOfNums[i] = new string(ArrayOfNums[i].ToCharArray().Reverse().ToArray());
                sum += int.Parse(ArrayOfNums[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
