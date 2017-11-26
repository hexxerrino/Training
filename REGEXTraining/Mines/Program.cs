using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string mineText1 = Console.ReadLine();
            StringBuilder mineText = new StringBuilder();
            mineText.Append(mineText1);

            var mines = Regex.Matches(mineText.ToString(), @"[<]([A-Za-z]{2})[>]")
                      .Cast<Match>();

            foreach (var mine in mines)
            {
                for (int i = mine.Index - Math.Abs((int)mine.Value[1] - (int)mine.Value[2]); 
                    i <= mine.Index + mine.Length + Math.Abs((int)mine.Value[1] - (int)mine.Value[2]) - 1; i++)
                {
                    mineText[i] = '_';
                }
            }

            Console.WriteLine(mineText.ToString());
        }
    }
}
