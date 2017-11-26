using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries__Lambda__LINQ_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string purviVhod = Console.ReadLine();
            string[] listOfWords = purviVhod.Split(' ');
            var wordDictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var word in listOfWords)
            {
                wordDictionary[word] = 0;

            }

            foreach (var word in listOfWords)
            {
                wordDictionary[word]++;
               
            }
            foreach (var pair in wordDictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write($"{pair.Key.ToLower()}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
