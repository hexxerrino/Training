using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string emails = Console.ReadLine();

            string[] legitEmails = Regex.Matches(emails, @"\b([1-9a-zA-Z.\-_]*)[@]([a-zA-Z-]*[.])*[a-zA-Z-]*\b")
                      .Cast<Match>()
                      .Select(m => m.Value)
                      .ToArray();

            foreach (var item in legitEmails)
            {
                Console.WriteLine(item);
            }
        }
    }
}
