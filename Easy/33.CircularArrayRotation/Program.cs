using System;
using System.Collections.Generic;
using System.Linq;

namespace _33.CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nkq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> array = Console.ReadLine().Split().ToList();

            int n = nkq[0];
            int k = nkq[1];
            int q = nkq[2];

            for (int i = 0; i < k; i++)
            {
                string lastItem = array[n - 1];

                for (int j = n - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastItem;

            }

            for (int i = 0; i < q; i++)
            {
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine(array[index]);
            }
        }
    }
}
