using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (countOfPeople <= 50)
            {
                if (package == "Normal")
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {((2500 + 500) * 0.95) / countOfPeople:f2}$");
                }
                else if (package == "Gold")
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {((2500 + 750) * 0.90) / countOfPeople:f2}$");
                }
                else if (package == "Platinum")
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {((2500 + 1000) * 0.85) / countOfPeople:f2}$");
                }
            }

            else if (countOfPeople > 50 && countOfPeople <= 100)
            {
                if (package == "Normal")
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {((5000 + 500) * 0.95) / countOfPeople:f2}$");
                }
                else if (package == "Gold")
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {((5000 + 750) * 0.90) / countOfPeople:f2}$");
                }
                else if (package == "Platinum")
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {((5000 + 1000) * 0.85) / countOfPeople:f2}$");
                }
            }

            else if (countOfPeople > 100 && countOfPeople <= 120)
            {
                if (package == "Normal")
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {((7500 + 500) * 0.95) / countOfPeople:f2}$");
                }
                else if (package == "Gold")
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {((7500 + 750) * 0.90) / countOfPeople:f2}$");
                }
                else if (package == "Platinum")
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {((7500 + 1000) * 0.85) / countOfPeople:f2}$");
                }
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
