using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pairOfCards = new Dictionary<string, List<string>>();
            List<string> currentInput = new List<string>();
            int currentSum = 0;

            do
            {
                currentInput = Console.ReadLine().Split(new Char[] { ',', ':' }, 
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                try
                {
                    for (int i = 1; i < currentInput.Count; i++)
                    {
                        if (!pairOfCards[currentInput[0]].Contains(currentInput[i]))
                        {
                            pairOfCards[currentInput[0]].Add(currentInput[i]);
                        }
                    }
                }
                catch (Exception)
                {
                    pairOfCards.Add(currentInput[0], new List<string> { currentInput[1] });
                    for (int i = 2; i < currentInput.Count; i++)
                    {
                        if (!pairOfCards[currentInput[0]].Contains(currentInput[i]))
                        {
                            pairOfCards[currentInput[0]].Add(currentInput[i]);
                        }
                    }
                }
            }
            while (currentInput[0] != "JOKER");

            foreach (var pair in pairOfCards)
            {
                pair.Value = pair.Value.Select(x => x)
            }
        }
    }
}
