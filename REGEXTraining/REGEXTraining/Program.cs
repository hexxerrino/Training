using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEXTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string[] fullNames = Regex.Matches(names, @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b")
                      .Cast<Match>()
                      .Select(m => m.Value)
                      .ToArray();

            Console.WriteLine(string.Join(" ", fullNames));
        }
    }
}
