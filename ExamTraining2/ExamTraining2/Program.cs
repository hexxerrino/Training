using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTraining2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            decimal wholePrice = 0;

            for (int i = 0; i < numOfInputs; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string[] date = Console.ReadLine().Split('/').ToArray();
                if (date[1][0] == '0')
                {
                    date[1] = date[1].Remove(0,1);
                }
                int numOfDays = DateTime.DaysInMonth(int.Parse(date[2]), int.Parse(date[1]));
                long capsuleCount = long.Parse(Console.ReadLine());

                decimal priceForCoffee = (numOfDays * capsuleCount) * pricePerCapsule;
                wholePrice += priceForCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceForCoffee:f2}");
            }
            Console.WriteLine($"Total: ${wholePrice:f2}");
        }
    }
}
