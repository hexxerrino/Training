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
            double currentInputValue = 0;
            int counter = 1;
            Dictionary<string, double> pair = new Dictionary<string, double>();

            do
            {
                if (counter % 2 != 0)
                {
                    currentInputName = Console.ReadLine();
                }
                else if (counter % 2 == 0)
                {
                    currentInputValue = double.Parse(Console.ReadLine());
                    try
                    {
                        pair[currentInputName] += currentInputValue;
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
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
