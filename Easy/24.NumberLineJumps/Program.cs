using System;
using System.Linq;

namespace _24.NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cangarooValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int x1 = cangarooValues[0];
            int v1 = cangarooValues[1];
            int x2 = cangarooValues[2];
            int v2 = cangarooValues[3];

            for (int i = 0; i < 10000; i++)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                {
                    Console.WriteLine("YES");
                    Environment.Exit(0);

                }
            }

            Console.WriteLine("NO");

        }
    }
}
