using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> players = Console.ReadLine().Split(' ').ToList();
            List<double> track = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var item in players)
            {
                double startfuel = (int)item[0];
                int indexReached = 0;
                for (int i = 0; i < track.Count; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        startfuel += track[i];
                    }
                    else
                    {
                        startfuel -= track[i];
                    }

                    if (startfuel <= 0)
                    {
                        indexReached = i;
                        break;
                    }
                }

                if (startfuel > 0)
                {
                    Console.WriteLine($"{item} - fuel left {startfuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{item} - reached {indexReached}");
                }
            }
        }
    }
}
