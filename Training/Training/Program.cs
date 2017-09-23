using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string proff = Console.ReadLine();
            double quant = double.Parse(Console.ReadLine());

            switch (proff)
            {
                case "Athlete":
                    Console.WriteLine($"The {proff} has to pay {quant * 0.70:f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {proff} has to pay {quant:f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {proff} has to pay {quant:f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proff} has to pay {quant * 1.7:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {proff} has to pay {quant * 1.2:f2}.");
                    break;
            }
        }
    }
}
