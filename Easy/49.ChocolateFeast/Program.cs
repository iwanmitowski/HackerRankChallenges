using System;
using System.Linq;

namespace _49.ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] ncm = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int money = ncm[0];
                int chocolateCost = ncm[1];
                int wrappersNeededForBar = ncm[2];

                int chocolatesCount = money / chocolateCost;
                int wrappersCount = chocolatesCount;

                
                while (wrappersCount >= wrappersNeededForBar)
                {
                    int newBars = wrappersCount / wrappersNeededForBar;
                    chocolatesCount += newBars;
                    wrappersCount -= newBars*wrappersNeededForBar;
                    wrappersCount += newBars;

                }

                Console.WriteLine(chocolatesCount);
            }
            
        }
    }
}
