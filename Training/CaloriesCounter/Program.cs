using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEngredients = int.Parse(Console.ReadLine());
            string currEngredient;
            double totalCalories = 0;

            for (int i = 0; i < numOfEngredients; i++)
            {
                currEngredient = Console.ReadLine();
                if (currEngredient.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
                {
                    totalCalories += 500;
                }
                else if (currEngredient.Equals("tomato sauce", StringComparison.CurrentCultureIgnoreCase))
                {
                    totalCalories += 150;
                }
                else if (currEngredient.Equals("salami", StringComparison.CurrentCultureIgnoreCase))
                {
                    totalCalories += 600;
                }
                else if (currEngredient.Equals("pepper", StringComparison.CurrentCultureIgnoreCase))
                {
                    totalCalories += 50;
                }

            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
