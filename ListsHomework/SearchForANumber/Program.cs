using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool bol = false;

            if (listOfIntegers.Count > comands[0])
            {
                listOfIntegers.RemoveRange(comands[0], listOfIntegers.Count - comands[0]);
            }

            
                listOfIntegers.RemoveRange(0, comands[1]);
            

            foreach (var item in listOfIntegers)
            {
                if (item == comands[2])
                {
                    bol = true;
                    break;
                }
            }

            if (bol)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
