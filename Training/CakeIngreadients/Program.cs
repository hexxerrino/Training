using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngreadients
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentIngreadient;
            int count = 0;
            do
            {
                currentIngreadient = Console.ReadLine();
                if (currentIngreadient == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {currentIngreadient}.");
                count++;
            } while (true);
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
