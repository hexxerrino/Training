using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<List<int>> listOfListOfInts = new List<List<int>>();
            listOfListOfInts.Add(new List<int>() { listOfIntegers[0]});
            bool check = false;

            for (int i = 1; i < listOfIntegers.Count; i++)
            {
                for (int j = 0; j < listOfListOfInts.Count; j++)
                {
                    if (listOfListOfInts[j].Last() < listOfIntegers[i])
                    {
                        listOfListOfInts[j].Add(listOfIntegers[i]);
                        check = true;
                    }
                }

                if (check == false)
                {
                    for (int j = 0; j < listOfListOfInts.Count; j++)
                    {
                        for (int k = listOfListOfInts[j].Count - 1; k >= 0; k--)
                        {
                            if (listOfListOfInts[j][k] < listOfIntegers[i])
                            {
                                listOfListOfInts.Add(new List<int>());
                                for (int l = 0; l <= k; l++)
                                {
                                    listOfListOfInts[listOfListOfInts.Count - 1].Add(listOfListOfInts[j][l]);
                                }
                                listOfListOfInts[listOfListOfInts.Count - 1].Add(listOfIntegers[i]);
                            }
                            break;
                        }
                        break;
                    }

                }
                else if (check == true)
                {
                    check = false;
                }

                if (listOfListOfInts.Count > 1)
                {
                    for (int j = 0; j < listOfListOfInts.Count; j++)
                    {
                        for (int k = 0; k < listOfListOfInts.Count; k++)
                        {
                            if (listOfListOfInts[j] == listOfListOfInts[k] && j != k)
                            {
                                listOfListOfInts.RemoveAt(k);
                            }
                        }
                    }
                }
            }

            int max = 0;
            int index = 0;

            for (int i = 0; i < listOfListOfInts.Count; i++)
            {
                if (listOfListOfInts[i].Count > max)
                {
                    max = listOfListOfInts[i].Count;
                    index = i;
                }
            }

            for (int i = 0; i < listOfListOfInts[index].Count; i++)
            {
                Console.Write($"{listOfListOfInts[index][i]} ");
            }
            Console.WriteLine();
        }
    }
}
