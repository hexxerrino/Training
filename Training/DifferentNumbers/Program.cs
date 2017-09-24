using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum - firstNum < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                int a = firstNum;
                int b = firstNum + 1;
                int c = firstNum + 2;
                int d = firstNum + 3;
                int e = firstNum + 4;
                Console.WriteLine($"{a} {b} {c} {d} {e}");
                do
                {
                    if (e < secondNum)
                    {
                        e++;
                        Console.WriteLine($"{a} {b} {c} {d} {e}");
                    }
                    else if (e - d > 1)
                    {
                        d++;
                        e = d + 1;
                        Console.WriteLine($"{a} {b} {c} {d} {e}");
                    }
                    else if (d - c > 1)
                    {
                        c++;
                        d = c + 1;
                        e = d + 1;
                        Console.WriteLine($"{a} {b} {c} {d} {e}");
                    }
                    else if (c - b > 1)
                    {
                        b++;
                        c = b + 1;
                        d = c + 1;
                        e = d + 1;
                        Console.WriteLine($"{a} {b} {c} {d} {e}");
                    }
                    else if (b - a > 1)
                    {
                        a++;
                        b = a + 1;
                        c = b + 1;
                        d = c + 1;
                        e = d + 1;
                        Console.WriteLine($"{a} {b} {c} {d} {e}");
                    }
                } while (secondNum - a > 4);
            }
        }
    }
}
