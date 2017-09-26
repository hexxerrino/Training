using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (int i = (int)firstLetter; i <= (int)secondLetter; i++)
            {
                if ((char)i == thirdLetter)
                {
                    i++;
                }
                if (i > (int)secondLetter)
                {
                    break;
                }
                for (int j = (int)firstLetter; j <= (int)secondLetter; j++)
                {
                    if ((char)j == thirdLetter)
                    {
                        j++;
                    }
                    if (j > (int)secondLetter)
                    {
                        break;
                    }
                    for (int k = (int)firstLetter; k <= (int)secondLetter; k++)
                    {
                        if ((char)k == thirdLetter)
                        {
                            k++;
                        }
                        if (k > (int)secondLetter)
                        {
                            break;
                        }
                        Console.Write($"{(char)i}{(char)j}{(char)k} ");
                    }
                }
            }
        }
    }
}
