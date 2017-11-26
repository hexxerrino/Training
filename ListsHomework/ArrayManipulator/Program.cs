using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> currentInput = new List<string>();

            do
            {
                currentInput = Console.ReadLine().Split(' ').ToList();

                if (currentInput[0] == "add")
                {
                    listOfIntegers.Insert(int.Parse(currentInput[1]), int.Parse(currentInput[2]));
                }

                else if (currentInput[0] == "addMany")
                {
                    for (int i = currentInput.Count - 1; i >= 2; i--)
                    {
                        listOfIntegers.Insert(int.Parse(currentInput[1]), int.Parse(currentInput[i]));
                    }
                }

                else if (currentInput[0] == "contains")
                {
                    bool bol = false;
                    int index = 0;
                    for (int i = 0; i < listOfIntegers.Count; i++)
                    {
                        if (int.Parse(currentInput[1]) == listOfIntegers[i])
                        {
                            bol = true;
                            index = i;
                            break;
                        }
                        
                    }
                    if (bol)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }

                else if (currentInput[0] == "remove")
                {
                    listOfIntegers.RemoveAt(int.Parse(currentInput[1]));
                }

                else if (currentInput[0] == "shift")
                {
                    int filler = 0;
                    for (int i = 0; i < int.Parse(currentInput[1]); i++)
                    {
                        filler = listOfIntegers[0];
                        for (int j = 0; j < listOfIntegers.Count; j++)
                        {
                            if (j == listOfIntegers.Count - 1)
                            {
                                listOfIntegers[j] = filler;
                            }
                            else
                            {
                                listOfIntegers[j] = listOfIntegers[j + 1];
                            }
                        }
                    }
                }

                else if (currentInput[0] == "sumPairs")
                {
                    List<int> pairedList = new List<int>();

                    for (int i = 0, j = 0; i < listOfIntegers.Count; i += 2, j++)
                    {
                        if (i + 1 >= listOfIntegers.Count)
                        {
                            pairedList.Add(listOfIntegers[i]);
                        }
                        else
                        {
                            pairedList.Add(listOfIntegers[i] + listOfIntegers[i + 1]);
                        }
                    }
                    listOfIntegers.Clear();

                    for (int i = 0; i < pairedList.Count; i++)
                    {
                        listOfIntegers.Add(pairedList[i]);
                    }
                }
            }
            while (currentInput[0] != "print");

            Console.WriteLine($"[{string.Join(", ", listOfIntegers)}]");
        }
    }
}
