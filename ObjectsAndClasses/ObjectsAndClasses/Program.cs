using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new
            {
                year = 2016,
                month = 10,
                day = 12,
            };
            Console.WriteLine(birthday.day);
        }
    }
}
