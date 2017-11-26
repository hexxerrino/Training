using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetdessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            long guestsCount = long.Parse(Console.ReadLine());
            double banana = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double berriesForKilo = double.Parse(Console.ReadLine());

            double unitsNeeded = guestsCount / 6;
            if (guestsCount % 6 > 0)
            {
                unitsNeeded++;
            }

            double moneyForBanana = unitsNeeded * 2 * banana;
            double moneyForEggs = unitsNeeded * 4 * eggs;
            double moneyForBerries = berriesForKilo / 5 * unitsNeeded;
            double allMoney = moneyForBanana + moneyForEggs + moneyForBerries;

            if (allMoney <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allMoney:f2}lv.");
            }
            else
            {
                double moreMoney = allMoney - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moreMoney:f2}lv more.");
            }

        }
    }
}
