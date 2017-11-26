using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentInput = new string[2];
            Regex onlyDigits = new Regex(@"[\d]+");
            Regex nonDigits = new Regex(@"[\D]+");
            Regex digitsAndLetters = new Regex(@"^[\da-zA-Z]+$");
            List<string> PM1 = new List<string>();
            List<string> PM2 = new List<string>();
            List<string> broadcast1 = new List<string>();
            List<string> broadcast2 = new List<string>();

            do
            {

                currentInput = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.None).ToArray();
                if (currentInput[0] == "Hornet is Green")
                {
                    break;
                }

                if (currentInput.Count() == 2)
                {
                    

                    if (currentInput[0] == "Hornet is Green")
                    {
                        break;
                    }

                    if (onlyDigits.IsMatch(currentInput[0]) && digitsAndLetters.IsMatch(currentInput[1]))
                    {
                        char[] charArray = currentInput[0].ToCharArray();
                        Array.Reverse(charArray);
                        string reversedInput = new string(charArray);

                        PM1.Add(reversedInput);
                        PM2.Add(currentInput[1]);
                    }

                    else if (nonDigits.IsMatch(currentInput[0]) && digitsAndLetters.IsMatch(currentInput[1]))
                    {
                        string reversedCase = new string(currentInput[1].Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                          char.ToLower(c) : char.ToUpper(c)) : c).ToArray());

                        broadcast1.Add(reversedCase);
                        broadcast2.Add(currentInput[0]);
                    }
                }
            }
            while (true);
            try
            {
                Console.WriteLine("Broadcasts:");
                for (int i = 0; i < broadcast1.Count; i++)
                {
                    Console.WriteLine($"{broadcast1[i]} -> {broadcast2[i]}");
                }
                if (broadcast1.Count() == 0)
                {
                    Console.WriteLine("None");
                }
                Console.WriteLine("Messages:");
                for (int i = 0; i < PM1.Count; i++)
                {
                    Console.WriteLine($"{PM1[i]} -> {PM2[i]}");
                }
                if (PM1.Count() == 0)
                {
                    Console.WriteLine("None");
                }
            }
            catch
            {
                Console.WriteLine("pishok");
            }
        }
    }
}
