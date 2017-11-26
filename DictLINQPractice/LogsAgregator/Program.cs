using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLogs = int.Parse(Console.ReadLine());
            string[] currentInput = new string[3];

            List<string> listOfIPs = new List<string>();
            Dictionary<string, int> dictDuration = new Dictionary<string, int>();
            Dictionary<string, List <string>> dictIP = new Dictionary<string, List<string>>();

            for (int i = 0; i < numOfLogs; i++)
            {
                currentInput = Console.ReadLine().Split(' ');
                try
                {
                    dictDuration[currentInput[1]] += int.Parse(currentInput[2]);
                }
                catch (Exception)
                {
                    dictDuration.Add(currentInput[1], int.Parse(currentInput[2]));
                }

                try
                {
                    if (!dictIP[currentInput[1]].Contains(currentInput[0]))
                    {
                        dictIP[currentInput[1]].Add(currentInput[0]);
                    }
                }
                catch (Exception)
                {
                    dictIP.Add(currentInput[1], new List<string>());
                    dictIP[currentInput[1]].Add(currentInput[0]);
                }
            }

            foreach (var item in dictDuration)
            {
                Console.WriteLine($"{item.Key}: {item.Value} [{string.Join(", ", dictIP[item.Key])}]");
            }
        }
    }
}
