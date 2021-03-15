using System;
using System.Linq;

namespace _11.BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] records = new int[2];

            int min = int.MaxValue;
            int max = int.MinValue;

            int n = int.Parse(Console.ReadLine());
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    if (i > 0)
                    {
                        records[0]++;
                    }
                }
                if (scores[i] < min)
                {
                    min = scores[i];
                    if (i > 0)
                    {
                        records[1]++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",records));
        }
    }
}
