using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List < string > symbols = Regex.Split(Console.ReadLine(), @"\s*,\s*").ToList();

            foreach (var item in symbols)
            {
                if (item.Count() != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (Regex.IsMatch(item, @"[@#$^]{20}"))
                {
                    Console.WriteLine($"ticket \"{item}\" - 10{item[0]} Jackpot!");
                }
                else
                {
                    string firstHalf = item.Substring(0, 10);
                    string secondHalf = item.Substring(9, 10);
                    if (Regex.IsMatch(firstHalf, @"([@#$^]{6}(.){4}|(.){1}[@#$^]{6}(.){3}|(.){2}[@#$^]{6}(.){2}
                                                 |(.){3}[@#$^]{6}(.){1}|(.){4}[@#$^]{6})") 
                                                 && Regex.IsMatch(secondHalf, @"([@#$^]{6}(.){4}|(.){1}[@#$^]{6}(.){3}|(.){2}[@#$^]{6}(.){2}
                                                 |(.){3}[@#$^]{6}(.){1}|(.){4}[@#$^]{6})"))
                    {

                        Console.WriteLine($"ticket \"{item}\" - ");
                    }
                }
            }

        }
    }
}
