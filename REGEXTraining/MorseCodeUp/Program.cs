using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeUp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> codeInput = Console.ReadLine().Split('|').ToList();
            int[] asciiCodeOfAChar = new int[codeInput.Count()];
            int sum = 0;
            int sequenceCount = 0;

            for (int i = 0; i < codeInput.Count; i++)
            {
                if (codeInput[i][0] == '0')
                {
                    sum += 3;
                }
                else
                {
                    sum += 5;
                }
                for (int j = 1; j < codeInput[i].Length; j++)
                {
                    if (codeInput[i][j] == '0')
                    {
                        sum += 3;
                    }
                    else
                    {
                        sum += 5;
                    }

                    if (codeInput[i][j] == codeInput[i][j - 1])
                    {
                        sequenceCount++;
                    }
                    else
                    {
                        if (sequenceCount > 0)
                        {
                            sum += sequenceCount + 1;
                        }
                        sequenceCount = 0; 
                    }
                }
                if (sequenceCount > 0)
                {
                    sum += sequenceCount + 1;
                }
                asciiCodeOfAChar[i] = sum;
                sum = 0;
                sequenceCount = 0;
            }
            foreach (var item in asciiCodeOfAChar)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
        }
    }
}
