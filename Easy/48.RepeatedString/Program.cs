using System;
using System.Linq;

namespace _48.RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());

            char[] wordToChar = word.ToCharArray();
            long letterA = word.ToCharArray().Where(x => x == 'a').Count();

            int wordLength = word.Length;

            long wordTimesN = n / wordLength;
            long wordTimesNLeftSymbols = n % wordLength;
           
            long symbolsToAdd = 0;

            for (int i = 0; i < wordTimesNLeftSymbols; i++)
            {
                if (wordToChar[i] == 'a')
                {
                    symbolsToAdd++;
                }
            }
            Console.WriteLine(wordTimesN * letterA + symbolsToAdd);
        }
    }
}
