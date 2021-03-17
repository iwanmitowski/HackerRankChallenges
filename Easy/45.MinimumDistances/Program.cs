using System;
using System.Collections.Generic;
using System.Linq;

namespace _45.MinimumDistances
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            int minDistance = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int firstElement = arr.First(x => x == arr[i]);
                int lastElement = arr.Last(x => x == arr[i]);

                int indexFirst = arr.IndexOf(firstElement);
                 
                int indexLast = arr.LastIndexOf(lastElement);

                if (indexFirst == indexLast)
                {
                    continue;
                }

                int diff = Math.Abs(indexFirst - indexLast);

                if (diff<minDistance)
                {
                    minDistance = diff;
                }
            }

            if (minDistance==int.MaxValue)
            {
                minDistance = -1;
            }

            Console.WriteLine(minDistance);
        }
    }
}
