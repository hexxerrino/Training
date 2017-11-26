using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProp
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (type == "face")
            {
                double faceDiag = FaceDiagonal(side);
                Console.WriteLine($"{faceDiag:f2}");
            }
            else if (type == "space")
            {
                double spaceDiag = SpaceDiagonal(side);
                Console.WriteLine($"{spaceDiag:f2}");
            }
            else if (type == "volume")
            {
                double volume = Volume(side);
                Console.WriteLine($"{volume:f2}");
            }
            else if (type == "area")
            {
                double sArea = SurfaceArea(side);
                Console.WriteLine($"{sArea:f2}");
            }
        }

        static double FaceDiagonal(double side)
        {
            double answer = Math.Sqrt(2 * Math.Pow(side, 2));
            return answer;
        }

        static double SpaceDiagonal(double side)
        {
            double answer = Math.Sqrt(3 * Math.Pow(side, 2));
            return answer;
        }

        static double Volume(double side)
        {
            double answer = Math.Pow(side, 3);
            return answer;
        }

        static double SurfaceArea(double side)
        {
            double answer = 6 * Math.Pow(side, 2);
            return answer;
        }
    }
}
