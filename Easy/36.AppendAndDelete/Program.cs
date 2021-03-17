using System;

namespace _36.AppendAndDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToConvert = Console.ReadLine();
            string wordExample = Console.ReadLine();
            int iterations = int.Parse(Console.ReadLine());

            int wordToConvertLength = wordToConvert.Length;
            int wordExampleLength = wordExample.Length;

            int counter = 0;

            for (int i = 0; i < Math.Min(wordToConvertLength, wordExampleLength); i++)
            {
                if (wordToConvert[i] == wordExample[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            int leftSymbolsToRemove = wordToConvertLength - counter;
            int leftSymbolsToAdd = wordExampleLength - counter;

            if (wordToConvertLength < wordExampleLength)
            {
                leftSymbolsToRemove = wordToConvertLength+1;
                leftSymbolsToAdd = wordExampleLength;

            }

            if (leftSymbolsToRemove + leftSymbolsToAdd <= iterations)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
