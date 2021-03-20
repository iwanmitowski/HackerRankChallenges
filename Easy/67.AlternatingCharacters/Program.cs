using System;
using System.Collections.Generic;
using System.Linq;

namespace _67.AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                List<char> word = Console.ReadLine().ToCharArray().ToList();
                int startingCount = word.Count;
                for (int i = 0; i < word.Count - 1; i++)
                {
                    if (word[i] == word[i + 1])
                    {
                        word.RemoveAt(i);
                        i--;
                    }
                }

                Console.WriteLine(startingCount-word.Count);
            }
            
        }
    }
}
