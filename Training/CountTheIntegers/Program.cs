using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                try
                {
                    int whatever = int.Parse(Console.ReadLine());
                    count++;
                }
                catch
                {
                    break;
                }
            } while (true);
            Console.WriteLine(count);
        }
    }
}
