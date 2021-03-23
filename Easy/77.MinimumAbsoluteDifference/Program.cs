using System;
using System.Linq;

namespace _77.MinimumAbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long[] nums = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long minAbsDiff = int.MaxValue;

            for (long i = 0; i < t-1; i++)
            {
                for (long j = i+1; j < t; j++)
                {
                    long calc = Math.Abs(nums[i] - nums[j]);
                    if (calc<minAbsDiff)
                    {
                        minAbsDiff =calc;
                    }
                }
            }

            Console.WriteLine(minAbsDiff);
        }
    }
}
