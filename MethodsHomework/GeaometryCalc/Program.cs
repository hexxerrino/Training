using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeaometryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateTriangle(side, height):f2}");
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateSquare(side):f2}");
            }
            else if (type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateRectangle(width,height):f2}");
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateCircle(radius):f2}");
            }
        }

        static double CalculateTriangle(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        static double CalculateSquare(double side)
        {
            double area = side * side;
            return area;
        }

        static double CalculateRectangle(double width, double height)
        {
            double area = width * height;   
                return area;
        }

        static double CalculateCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
