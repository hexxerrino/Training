using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            var spisul = new List<int>() { 1,2,3,4,5,6,67,78,8,9,0,0,4,3,4,6,5};
            Console.WriteLine(spisul.Min());
        }
    }
}
