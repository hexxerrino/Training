using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = Console.ReadLine();
            foreach (var c in mystring)
            {
                string result = GetEscapeSequence(c);
                Console.Write(result);
            }
            Console.WriteLine();
        }

        private static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
