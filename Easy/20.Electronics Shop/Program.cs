using System;
using System.Collections.Generic;
using System.Linq;

namespace _20.Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bnm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int b = bnm[0];

            List<int> keyboards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> usbs= Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxSumToSpend = -1;

            for (int i = 0; i < usbs.Count; i++)
            {
                for (int j = 0; j < keyboards.Count; j++)
                {
                    if (usbs[i]+keyboards[j]>maxSumToSpend && usbs[i] + keyboards[j]<=b)
                    {
                        maxSumToSpend = usbs[i] + keyboards[j];
                    }
                }
            }


            Console.WriteLine(maxSumToSpend);

        }
    }
}
