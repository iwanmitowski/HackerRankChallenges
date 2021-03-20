using System;
using System.Linq;

namespace _68.BeautifulBinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] word = Console.ReadLine().ToCharArray();
            int counter = 0;

            for (int i = 0; i < word.Length - 2; i++)
            {
                if (word[i] == '0' && word[i + 1] == '1' && word[i + 2] == '0')
                {
                    counter++;

                    word[i + 2] = '1';

                    i = -1;
                }

            }

            Console.WriteLine(counter);
        }
    }
}
