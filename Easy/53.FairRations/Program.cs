using System;
using System.Linq;

namespace _53.FairRations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] queue = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < queue.Length - 1; i++)
            {
                if (queue[i] % 2 == 1)
                {
                    queue[i] += 1;
                    queue[i + 1] += 1;
                    count += 2;
                }
                else
                {
                    continue;
                }
                
            }

            if (queue[n-1]%2==1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine(count);
            }

        }
    }
}
