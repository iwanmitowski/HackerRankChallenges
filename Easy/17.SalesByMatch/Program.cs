using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> socks = Console.ReadLine().Split().Select(int.Parse).OrderBy(s=>s).ToList();

            int pairs = 0;

            for (int i = 1; i < n; i++)
            {
                if (socks[i-1]==socks[i])
                {
                    pairs++;
                    i++;
                }
            }

            Console.WriteLine(pairs);
                
                
            

        }
    }
}
