using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordGiven = Console.ReadLine();

            if (wordGiven.EndsWith("y"))
            {
                Console.WriteLine($"{wordGiven.Remove(wordGiven.Length - 1, 1)}ies");
            }
            else if (wordGiven.EndsWith("o") 
                || wordGiven.EndsWith("s") 
                || wordGiven.EndsWith("x")
                || wordGiven.EndsWith("z"))
            {
                Console.WriteLine($"{wordGiven}es");
            }
            else if (wordGiven.EndsWith("ch")
                || wordGiven.EndsWith("sh"))
            {
                Console.WriteLine($"{wordGiven}es");
            }
            else
            {
                Console.WriteLine($"{wordGiven}s");
            }
        }
    }
}
