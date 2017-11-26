using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string[] currentInput = new string[3];

            do
            {
                currentInput = Console.ReadLine().Split(' ').ToArray();

                if (currentInput[0] == "A")
                {
                    phoneBook[currentInput[1]] = currentInput[2];
                }
                else if (currentInput[0] == "S")
                {
                    if (phoneBook.ContainsKey(currentInput[1]))
                    {
                        Console.WriteLine($"{currentInput[1]} -> {phoneBook[currentInput[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {currentInput[1]} does not exist.");
                    }
                }
                else if (currentInput[0] == "ListAll")
                {
                    phoneBook = phoneBook.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var pair in phoneBook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
            }
            while (currentInput[0] != "END");
        }
    }
}
