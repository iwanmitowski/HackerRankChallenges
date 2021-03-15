using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            List<int> line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> line2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int valids = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (line1.TrueForAll(x => i % x == 0))
                {
                    if (line2.TrueForAll(x=>x%i==0))
                    {
                        valids++;
                    }
                }
            }
            Console.WriteLine(valids);
        }
    }
}
