using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictLINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentInputName = string.Empty;
            string currentInputValue = string.Empty;
            int counter = 1;
            Dictionary<string, string> pair = new Dictionary<string, string>();

            do
            {
                if (counter % 2 != 0)
                {
                    currentInputName = Console.ReadLine();
                }
                else if (counter % 2 == 0)
                {
                    currentInputValue = Console.ReadLine();
                    try
                    {
                        pair[currentInputName] = currentInputValue;
                    }
                    catch (Exception)
                    {

                        pair.Add(currentInputName, currentInputValue);
                    }
                }
                counter++;
            } while (currentInputName != "stop");

            foreach (var item in pair)
            {
                if (item.Value.EndsWith("us", StringComparison.CurrentCultureIgnoreCase) == false && item.Value.EndsWith("uk", StringComparison.CurrentCultureIgnoreCase) == false)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                
            }
        }
    }
}