using System;
using System.Collections.Generic;
using System.Linq;

namespace _69.ClosestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long minDifference = long.MaxValue;

            List<long> firstIndexex = new List<long>();
            
            
            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    long difference = Math.Abs(numbers[i]-numbers[j]);

                    if (difference < minDifference&&difference!=0)
                    {
                        firstIndexex.Clear();
                        
                        firstIndexex.Add(numbers[i]);
                        firstIndexex.Add(numbers[j]);
                        
                        minDifference = difference;
                    }
                    else if (difference==minDifference)
                    {
                        firstIndexex.Add(numbers[i]);
                        firstIndexex.Add(numbers[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",firstIndexex.OrderBy(x=>x)));
        }
    }
}
