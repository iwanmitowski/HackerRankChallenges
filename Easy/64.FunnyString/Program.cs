using System;
using System.Collections.Generic;
using System.Linq;

namespace _64.FunnyString
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                bool isFunny = true;

                string word = Console.ReadLine();

                for (int k = 1; k < word.Length; k++)
                {
                    int diff = Math.Abs(word[k - 1] - word[k]);
                    int reversed = Math.Abs(word[word.Length - k] - word[word.Length - k - 1]);
                    if (diff != reversed)
                    {
                        isFunny = false;
                        break;
                    }
                }

                if (isFunny)
                {
                    Console.WriteLine("Funny");
                }
                else
                {
                    Console.WriteLine("Not Funny");
                }

            }
        }
    }
}
