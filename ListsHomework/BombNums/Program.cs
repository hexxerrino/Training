using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNums
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] listOflongegers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] BombNumAndPower = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = 0;

            for (long i = 0; i < listOflongegers.Length; i++)
            {
                if (listOflongegers[i] == BombNumAndPower[0])
                {
                    if (i < BombNumAndPower[1])
                    {
                        for (long j = 0; j <= BombNumAndPower[1]; j++)
                        {
                            listOflongegers[j] = 0;
                        }
                    }
                    else if ((listOflongegers.Length - (i + 1)) < BombNumAndPower[1])
                    {
                        for (long j = i - BombNumAndPower[1]; j < listOflongegers.Length; j++)
                        {
                            listOflongegers[j] = 0;
                        }
                    }
                    else
                    {
                        for (long j = i - BombNumAndPower[1]; j <= i + BombNumAndPower[1]; j++)
                        {
                            listOflongegers[j] = 0;
                        }
                    }
                }
            }

            for (long i = 0; i < listOflongegers.Length; i++)
            {
                if (listOflongegers[i] != 0)
                {
                    sum += listOflongegers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
