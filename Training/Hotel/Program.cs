using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());


            if (month == "May" && nightCount > 7)
            {
                Console.WriteLine($"Studio: {(nightCount * 50) * 0.95:f2} lv.");
                Console.WriteLine($"Double: {(nightCount * 65):f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 75):f2} lv.");
            }
            
            else if (month == "October" && nightCount > 7)
            {
                Console.WriteLine($"Studio: {((nightCount - 1) * 50) * 0.95:f2} lv.");
                Console.WriteLine($"Double: {(nightCount * 65):f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 75):f2} lv.");
            }

            else if (month == "May" || month == "October")
            {
                Console.WriteLine($"Studio: {nightCount * 50:f2} lv.");
                Console.WriteLine($"Double: {(nightCount * 65):f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 75):f2} lv.");
            }

            else if (month == "June" && nightCount > 14)
            {
                Console.WriteLine($"Studio: {nightCount * 60:f2} lv.");
                Console.WriteLine($"Double: {nightCount * 72 * 0.90:f2} lv.");
                Console.WriteLine($"Suite: {nightCount * 82:f2} lv.");
            }

            else if (month == "September" && nightCount > 7 && nightCount <= 14)
            {
                Console.WriteLine($"Studio: {(nightCount - 1) * 60:f2} lv.");
                Console.WriteLine($"Double: {(nightCount * 72):f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 82):f2} lv.");
            }

            else if (month == "September" && nightCount > 14)
            {
                Console.WriteLine($"Studio: {(nightCount - 1) * 60:f2} lv.");
                Console.WriteLine($"Double: {(nightCount * 72) * 0.90:f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 82):f2} lv.");
            }

            else if (month == "June" || month == "September")
            {
                Console.WriteLine($"Studio: {nightCount * 60:f2} lv.");
                Console.WriteLine($"Double: {nightCount * 72:f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 82):f2} lv.");
            }

            else if (month == "July" || month == "August" || month == "December" && nightCount > 14)
            {
                Console.WriteLine($"Studio: {nightCount * 68:f2} lv.");
                Console.WriteLine($"Double: {nightCount * 77:f2} lv.");
                Console.WriteLine($"Suite: {(nightCount * 89) * 0.85:f2} lv.");
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                Console.WriteLine($"Studio: {nightCount * 68:f2} lv.");
                Console.WriteLine($"Double: {nightCount * 77:f2} lv.");
                Console.WriteLine($"Suite: {nightCount * 89:f2} lv.");
            }
        }
    }
}


