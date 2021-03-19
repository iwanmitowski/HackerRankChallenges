using System;
using System.Collections.Generic;
using System.Linq;

namespace _61.HackerRankInString
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                var hackerrank = new Queue<char>("hackerrank".ToCharArray());

                char[] word = Console.ReadLine().ToCharArray();

                foreach (var c in word)
                {
                    if (c==hackerrank.Peek())
                    {
                        hackerrank.Dequeue();
                    }
                    if (hackerrank.Count==0)
                    {
                        Console.WriteLine("YES");
                    }
                }
            }

            
                Console.WriteLine("NO");
            
        }
        
    }
}

