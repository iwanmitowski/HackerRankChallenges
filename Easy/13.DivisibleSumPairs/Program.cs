using System;
using System.Linq;

namespace _13.DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nk[0];
            int k = nk[1];

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int sum = nums[i - 1] + nums[j];
                    if (sum % k==0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
