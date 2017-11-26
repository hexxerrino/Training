using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            List<string> strings = Regex.Split(input, @"[0-9]+").ToList();
            List<string> nums = Regex.Split(input, @"\D+").ToList();
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i] == string.Empty)
                {
                    strings.Remove(strings[i]);
                }
            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == string.Empty)
                {
                    nums.Remove(nums[i]);
                }
            }

            string whatever = string.Join("", strings);
            int count = (new HashSet<char>(whatever)).Count;
            if (whatever.Contains(' '))
            {
                count--;
            }

            for (int i = 0; i < strings.Count; i++)
            {
                strings[i] = string.Concat(Enumerable.Repeat(strings[i], int.Parse(nums[i])));
            }

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(string.Join("", strings));
        }
    }
}
