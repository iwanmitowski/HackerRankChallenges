using System;
using System.Linq;

namespace _47.SherlockАndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

                long start = input[0];
                long end = input[1];

                int squares = 0;

                for (long j = start; j <= end; j++)
                {
                    if (Math.Sqrt(j)%1==0)
                    {
                        squares++;
                    }
                }

                Console.WriteLine(squares);
            }
        }
    }
}
