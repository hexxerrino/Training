using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            string[] fullNames = Regex.Matches(numbers, @"(\+359)( |-)[2](\2)[\d]{3}(\2)[\d]{4}\b")
                      .Cast<Match>()
                      .Select(m => m.Value)
                      .ToArray();

            Console.WriteLine(string.Join(", ", fullNames));
        }
    }
}
