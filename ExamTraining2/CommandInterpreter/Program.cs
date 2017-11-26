using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Regex.Split(Console.ReadLine(), @"\s+").ToList();
            List<string> currentCommand = new List<string>();

            do
            {
                currentCommand = Regex.Split(Console.ReadLine(), @"\s+").ToList();
                if (currentCommand[0] == "reverse")
                {
                    try
                    {
                        List<string> cutInput = input.GetRange(int.Parse(currentCommand[2]), int.Parse(currentCommand[4]));
                        cutInput.Reverse();
                        for (int i = 0; i < cutInput.Count; i++)
                        {
                            input[int.Parse(currentCommand[2]) + i] = cutInput[i];
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }
                else if (currentCommand[0] == "sort")
                {
                    try
                    {
                        List<string> cutInput = input.GetRange(int.Parse(currentCommand[2]), int.Parse(currentCommand[4]));
                        cutInput = cutInput.OrderBy(x => x).ToList();
                        for (int i = 0; i < cutInput.Count; i++)
                        {
                            input[int.Parse(currentCommand[2]) + i] = cutInput[i];
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (currentCommand[0] == "rollLeft")
                {
                    if (int.Parse(currentCommand[1]) < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        string filler = string.Empty;
                        string filler2 = string.Empty;
                        for (int i = 0; i < int.Parse(currentCommand[1]); i++)
                        {
                            filler = input[0];
                            for (int j = input.Count - 1; j >= 0; j--)
                            {
                                filler2 = input[j];
                                input[j] = filler;
                                filler = filler2;
                            }
                        }
                    }
                }                
                else if (currentCommand[0] == "rollRight")
                {
                    if (int.Parse(currentCommand[1]) < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        string filler = string.Empty;
                        string filler2 = string.Empty;
                        for (int i = 0; i < int.Parse(currentCommand[1]); i++)
                        {
                            filler = input.Last();
                            for (int j = 0; j < input.Count; j++)
                            {
                                filler2 = input[j];
                                input[j] = filler;
                                filler = filler2;
                            }
                        }
                    }
                    
                }
            }
            while (currentCommand[0] != "end");

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
