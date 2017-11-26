using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesAvailable = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            List<string> songsAvailable = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            Dictionary<string, Person> dictOfPersons = new Dictionary<string, Person>();
            string[] currentInput = new string[3];

            do
            {
                currentInput = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
                if (namesAvailable.Contains(currentInput[0]) && songsAvailable.Contains(currentInput[1]))
                {
                    try
                    {
                        if (!dictOfPersons[currentInput[0]].AwardNames.Contains(currentInput[2]))
                        {
                            dictOfPersons[currentInput[0]].AwardNumber++;
                            dictOfPersons[currentInput[0]].AwardNames.Add(currentInput[2]);
                        }
                    }
                    catch (Exception)
                    {
                        dictOfPersons.Add(currentInput[0], new Person());
                        dictOfPersons[currentInput[0]].AwardNumber++;
                        dictOfPersons[currentInput[0]].AwardNames.Add(currentInput[2]);
                    }
                  
                }
            }
            while (currentInput[0] != "dawn");

            dictOfPersons = dictOfPersons.OrderByDescending(x => x.Value.AwardNumber).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dictOfPersons)
            {
                item.Value.AwardNames = item.Value.AwardNames.OrderBy(x => x).ToList();
            }

            foreach (var item in dictOfPersons)
            {
                Console.WriteLine($"{item.Key}: {item.Value.AwardNumber} awards");
                foreach (var item2 in item.Value.AwardNames)
                {
                    Console.WriteLine($"--{item2}");
                }
            }

            if (dictOfPersons.Count < 1)
            {
                Console.WriteLine("No awards");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int AwardNumber { get; set; }
        public List<string> AwardNames = new List<string>();
    }
}
