using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            char k = key[0];
            List<string> currentInput = new List<string>();
            Dictionary<string, int> goalsDict = new Dictionary<string, int>();
            Dictionary<string, int> scoreDict = new Dictionary<string, int>();

            do
            {
                currentInput = Console.ReadLine().Split(' ').ToList();
                if (currentInput[0] == "final")
                {
                    break;
                }
                currentInput[0] = Regex.Split(currentInput[0], key).ToArray()[1].ToString();
                currentInput[0] = currentInput[0].Remove(0, key.Length);
                currentInput[0] = currentInput[0].Remove(currentInput[0].Count() - key.Length, key.Length);
                string team1 = currentInput[0].ToUpper();
                team1 = Reverse(team1);

                currentInput[1] = Regex.Split(currentInput[1], key).ToArray()[1].ToString();
                currentInput[1] = currentInput[1].Remove(0, key.Length);
                currentInput[1] = currentInput[1].Remove(currentInput[1].Count() - key.Length, key.Length);
                string team2 = currentInput[1].ToUpper();
                team2 = Reverse(team2);

                int team1Goals = int.Parse(currentInput[2][0].ToString());
                int team2Goals = int.Parse(currentInput[2][2].ToString());

                if (team1Goals > team2Goals)
                {
                    try
                    {
                        scoreDict[team1] += 3;
                    }
                    catch (Exception)
                    {

                        scoreDict.Add(team1, 3);
                    }
                    try
                    {
                        scoreDict[team2] += 0;
                    }
                    catch (Exception)
                    {

                        scoreDict.Add(team2, 0);
                    }
                }
                else if (team1Goals < team2Goals)
                {
                    try
                    {
                        scoreDict[team2] += 3;
                    }
                    catch (Exception)
                    {

                        scoreDict.Add(team2, 3);
                    }
                    try
                    {
                        scoreDict[team1] += 0;
                    }
                    catch (Exception)
                    {

                        scoreDict.Add(team1, 0);
                    }
                }
                else
                {
                    try
                    {
                        scoreDict[team1]++;
                    }
                    catch (Exception)
                    {
                        scoreDict.Add(team1, 1);
                    }
                    try
                    {
                        scoreDict[team2]++;
                    }
                    catch (Exception)
                    {
                        scoreDict.Add(team2, 1);
                    }
                }

                try
                {
                    goalsDict[team1] += team1Goals;
                }
                catch (Exception)
                {
                    goalsDict.Add(team1, team1Goals);
                }
                try
                {
                    goalsDict[team2] += team2Goals;
                }
                catch (Exception)
                {
                    goalsDict.Add(team2, team2Goals);
                }
            }
            while (currentInput[0] != "final");

            foreach (var item in scoreDict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }




        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
