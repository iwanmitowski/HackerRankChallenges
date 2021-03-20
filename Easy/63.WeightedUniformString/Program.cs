using System;
using System.Collections.Generic;
using System.Linq;

namespace _63.WeightedUniformString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();

            char[] word = Console.ReadLine().ToCharArray();
            int q = int.Parse(Console.ReadLine());
            Dictionary<char, List<int>> wordSubstringValues = new Dictionary<char, List<int>>();

            foreach (var c in word)
            {
                if (wordSubstringValues.ContainsKey(c))
                {
                    continue;
                }
                wordSubstringValues.Add(c, new List<int>());

                int count = word.Where(x => x == c).Count();
                int value = alphabet.IndexOf(c) + 1;

                int maxPossibleValue = count * value;

                while (maxPossibleValue >= value)
                {
                    wordSubstringValues[c].Add(maxPossibleValue);

                    maxPossibleValue -= value;
                }
            }

            for (int i = 0; i < q; i++)
            {
                int querry = int.Parse(Console.ReadLine());

                bool isFound = false;

                foreach ((char c, List<int> values) in wordSubstringValues)
                {
                    foreach (int v in values)
                    {
                        if (values.Contains(querry))
                        {
                            Console.WriteLine("Yes");
                            isFound = true;
                            break;
                        }
                        
                    }
                    if (isFound)
                    {
                        break;
                    }
                    
                }
                if (isFound==false)
                {
                    Console.WriteLine("No");
                }

            }
        }
    }
}
