using System;

namespace _71.TheLoveLetterMystery
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());


            for (int i = 0; i < q; i++)
            {
                char[] word = Console.ReadLine().ToCharArray();
                int counter = 0;

                for (int j = (word.Length - 1)/2; j >= 0; j--)
                {
                    int ind = word.Length-1 - j;
                    if (word[j]!=word[ind])
                    {
                        counter += Math.Abs((int)word[j] - (int)word[ind]);
                    }
                    
                }
                Console.WriteLine(counter);
                
               
            }
        }
    }
}
