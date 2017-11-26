using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            if ((Math.Abs(a - a1)) >= (Math.Abs(x - x1)) && (Math.Abs(b - b1)) >= (Math.Abs(y - y1)))
            {

                PrintClosest(a, b, a1, b1);
            }
            else
            {

                PrintClosest(x, y, x1, y1);
            }
        }

        static void PrintClosest(double x1, double x2, double y1, double y2)
        {
            double firstDiagonal = Math.Pow(x1, 2) + Math.Pow(x2, 2);
            double secondDiagonal = Math.Pow(y1, 2) + Math.Pow(y2, 2);
            if (secondDiagonal >= firstDiagonal)
            {
                Console.Write("({0}, {1})", x1, x2);
                Console.WriteLine("({0}, {1})", y1, y2);
            }
            else
            {
                Console.Write("({0}, {1})", y1, y2);
                Console.WriteLine("({0}, {1})", x1, x2);
            }
        }
    }
}
