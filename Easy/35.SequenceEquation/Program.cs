using System;
using System.Collections.Generic;
using System.Linq;

namespace _35.SequenceEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequenceCount = int.Parse(Console.ReadLine());
            var userInput = Console.ReadLine().Split(' ');

            var sequenceDictionary = new Dictionary<int, int>();
            for (int i = 0; i < sequenceCount; i++)
            {
                sequenceDictionary.Add(int.Parse(userInput[i]), i + 1);

            }

            for (int x = 1; x <= sequenceCount; x++)
            {
                var ppy = sequenceDictionary[sequenceDictionary[x]];
                Console.WriteLine(ppy);
            }
        }
    }
}
