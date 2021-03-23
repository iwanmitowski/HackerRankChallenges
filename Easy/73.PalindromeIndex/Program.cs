using System;

namespace _73.PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int index = -1;

                char[] word = Console.ReadLine().ToCharArray();

                for (int j = (word.Length - 1) / 2; j >= 0; j--)
                {
                    int ind = word.Length - 1 - j;
                    if (word[j] != word[ind])
                    {
                        if (word[j]==word[ind-1])
                        {
                            index = ind;
                        }
                        else
                        {
                            index = j;

                        }
                    }

                }
                Console.WriteLine(index);
            }
        }
    }
}
