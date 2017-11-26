using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerbianMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentInput = string.Empty;
            Dictionary<string, Dictionary<string, int>> 
            dictionaryWithPlaces = new Dictionary<string, Dictionary<string, int>>();
            int index = 0;

            label:
            do
            {
                currentInput = Console.ReadLine();
                if (currentInput == "End")
                {
                    break;
                }

                for (int i = 0; i < currentInput.Length; i++)
                {
                    if (currentInput[i] == '1' || currentInput[i] == '2' || currentInput[i] == '3'
                        || currentInput[i] == '4'|| currentInput[i] == '5'|| currentInput[i] == '6'
                        || currentInput[i] == '7'|| currentInput[i] == '8'|| currentInput[i] == '9')
                    {
                        index = i;
                        break;
                    }
                }
                
                if (currentInput[currentInput.IndexOf('@') - 1] != ' ' 
                    || currentInput[index - 1] != ' ' )
                    
                {
                    goto label;
                }

                try
                {
                    string[] probagreshka = currentInput.Split(' ').ToArray();
                    int whatever = int.Parse(probagreshka[probagreshka.Count() - 1]);
                    int whatever2 = int.Parse(probagreshka[probagreshka.Count() - 2]);
                }
                catch (Exception)
                {
                    goto label;
                }

                string[] singerAndPlaceSplit = currentInput.Split('@').ToArray();

                singerAndPlaceSplit[0] = singerAndPlaceSplit[0].
                Remove(singerAndPlaceSplit[0].Count() - 1, 1); //Removes the space after the name

                singerAndPlaceSplit[1] = string.Join("", singerAndPlaceSplit[1].
                Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
                singerAndPlaceSplit[1] = singerAndPlaceSplit[1].Remove(singerAndPlaceSplit[1].Count() - 2, 2);
                //Removes all numbers and whitespaces

                string[] splitString = currentInput.Split(' ').ToArray();
                string ticketPrice = splitString[splitString.Count() - 2];
                string ticketCount = splitString[splitString.Count() - 1];

                try
                {
                    try
                    {
                        dictionaryWithPlaces[singerAndPlaceSplit[1]][singerAndPlaceSplit[0]]
                        += int.Parse(ticketCount) * int.Parse(ticketPrice);
                    }
                    catch (Exception)
                    {
                        dictionaryWithPlaces[singerAndPlaceSplit[1]].Add(singerAndPlaceSplit[0], 
                        int.Parse(ticketCount) * int.Parse(ticketPrice));
                    }
                }
                catch (Exception)
                {
                    dictionaryWithPlaces.Add(singerAndPlaceSplit[1], new Dictionary<string, int>());
                    dictionaryWithPlaces[singerAndPlaceSplit[1]].Add(singerAndPlaceSplit[0], 
                    int.Parse(ticketCount) * int.Parse(ticketPrice));
                }


            }
            while (currentInput != "End");

            foreach (var pair in dictionaryWithPlaces)
            {
                Console.WriteLine(pair.Key);
                foreach (var pair1 in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair1.Key} -> {pair1.Value}");
                }
            }
        }
    }
}
