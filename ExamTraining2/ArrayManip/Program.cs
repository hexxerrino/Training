using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long maxPower = hornets.Take(hornets.Count).Sum();

            for (int i = 0, j = 0; i < beehives.Count; i++)
            {
                if (beehives[i] >= maxPower)
                {
                    beehives[i] -= maxPower;
                    hornets.RemoveAt(j);
                    maxPower = hornets.Take(hornets.Count).Sum();
                }
                else
                {
                    beehives[i] = -1;
                }

                if (hornets.Count < 1)
                {
                    break;
                }
            }

            beehives.RemoveAll(x => x == -1);

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
