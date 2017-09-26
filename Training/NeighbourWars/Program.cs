using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {                  
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());
            int peshoHP = 100;
            int goshoHP = 100;
            int roundCount = 0;
            int restoreCount1 = 1;
            int restoreCount2 = 1;
            do
            {
                roundCount++;
                peshoHP -= goshoDMG;
                if (peshoHP <= 0)
                {
                    break;
                }
                if (restoreCount1 % 3 == 0 || restoreCount2 % 3 == 0)
                {
                    goshoHP += 10;
                    peshoHP += 10;
                }
                goshoHP -= peshoDMG;
                if (goshoHP <= 0)
                {
                    break;
                }
                if (restoreCount2 % 3 == 0)
                {
                    goshoHP += 10;
                    peshoHP += 10;                    
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP}");
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP}");
            }
            while (peshoHP > 0 && goshoHP > 0);

            if (peshoHP > goshoHP)
            {
                Console.WriteLine($"Pesho won in the {roundCount}th round.");
            }
            else if (goshoHP > peshoHP)
            {
                Console.WriteLine($"Gosho won in the {roundCount}th round.");
            }
        }
    }
}
