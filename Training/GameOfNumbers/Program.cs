using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int currA = 0;
            int currB = 0;
            int total = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    total++;
                    if (i + j == magic)
                    {
                        currA = i;
                        currB = j;
                    }
                }
            }

            if (currA + currB == magic)
            {
                Console.WriteLine($"Number found! {currA} + {currB} = {magic}");
            }
            else
            {
                Console.WriteLine($"{total} combinations - neither equals {magic}");
            }

	
        }
    }
}
