using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string masterCommand = string.Empty;
            string currentCommand = string.Empty;

            do
            {
                currentCommand = Console.ReadLine();

                if (currentCommand == "Odd")
                {
                    masterCommand = "Odd";
                    break;
                }
                else if (currentCommand == "Even")
                {
                    masterCommand = "Even";
                    break;
                }

                if (currentCommand[0] == 'D')
                {
                    listOfIntegers.RemoveAll(item => item == int.Parse(currentCommand.Split(' ')[1]));
                }
                else if (currentCommand[0] == 'I')
                {
                    listOfIntegers.Insert(int.Parse(currentCommand.Split(' ')[2]), int.Parse(currentCommand.Split(' ')[1]));
                }
            }
            while (true);

            if (masterCommand == "Odd")
            {
                foreach (var item in listOfIntegers)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write($"{item} ");
                    }

                }
            }
            else if (masterCommand == "Even")
            {
                foreach (var item in listOfIntegers)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
